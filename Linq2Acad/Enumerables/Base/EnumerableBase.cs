﻿using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq2Acad
{
  public abstract class EnumerableBase<T> : ObjectIdEnumerable<T> where T : DBObject
  {
    protected Database database;
    protected Transaction transaction;

    protected EnumerableBase(Database database, Transaction transaction, ObjectId containerID, Func<object, ObjectId> getID)
      : base(transaction, GetIDs(transaction, containerID, getID))
    {
      this.database = database;
      this.transaction = transaction;
      ID = containerID;
    }

    private static IEnumerable<ObjectId> GetIDs(Transaction transaction, ObjectId containerID, Func<object, ObjectId> getID)
    {
      var enumerable = (IEnumerable)transaction.GetObject(containerID, OpenMode.ForRead);

      foreach (var item in enumerable)
      {
        yield return getID(item);
      }
    }

    internal ObjectId ID { get; private set; }

    public override bool Contains(T value)
    {
      return Contains(value.ObjectId);
    }

    public virtual bool Contains(ObjectId id)
    {
      return IDs.Any(oid => oid.Equals(id));
    }

    public T Element(ObjectId id)
    {
      return (T)transaction.GetObject(id, OpenMode.ForRead);
    }

    public ImportResult<T> Import(T item)
    {
      return Import(item, false);
    }

    public ImportResult<T> Import(T item, bool replaceIfDuplicate)
    {
      if (item == null) throw new ArgumentNullException("item");
      return Import(new[] { item }, replaceIfDuplicate).First();
    }

    public IReadOnlyCollection<ImportResult<T>> Import(IEnumerable<T> items, bool replaceIfDuplicate)
    {
      if (items == null) throw new ArgumentNullException("items");

      if (items.Any(i => i.Database == database))
      {
        throw new Exception("Wrong database origin");
      }

      var result = new List<ImportResult<T>>();

      foreach (var item in items)
      {
        var ids = new ObjectIdCollection(new [] { item.ObjectId });
        var mapping = new IdMapping();
        var type = replaceIfDuplicate ? DuplicateRecordCloning.Replace : DuplicateRecordCloning.Ignore;
        database.WblockCloneObjects(ids, ID, mapping, type, false);

        result.Add(new ImportResult<T>((T)transaction.GetObject(mapping[item.ObjectId].Value, OpenMode.ForRead), mapping));
      }

      return result;
    }
  }
}
