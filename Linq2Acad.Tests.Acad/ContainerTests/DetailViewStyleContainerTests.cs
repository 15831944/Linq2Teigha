﻿using System;
using System.Linq;
using Linq2Acad;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using AcadTestRunner;

namespace Linq2Acad.Tests
{
  public class DetailViewStyleContainerTests
  {
    [CommandMethod("TestCreateDetailViewStyle")]
    public void TestCreateDetailViewStyle()
    {
      var notifier = new Notification("TestCreateDetailViewStyle");

      try
      {
        using (var db = AcadDatabase.Active())
        {
          var newDetailViewStyle = db.DetailViewStyles.Create("NewDetailViewStyle");
          
          var ok = Check.Dictionary(db.Database, db.Database.DetailViewStyleDictionaryId, dict => dict.Contains("NewDetailViewStyle"));
          if (!ok) { notifier.TestFailed("DetailViewStyle dictionary does not contain an element with name 'NewDetailViewStyle'"); return; }

          ok = Check.DictionaryIDs(db.Database, db.Database.DetailViewStyleDictionaryId, ids => ids.Any(id => id == newDetailViewStyle.ObjectId));
          if (!ok) { notifier.TestFailed("DetailViewStyle dictionary does not contain the newly created element"); return; }
        }
      }
      catch (System.Exception e)
      {
        notifier.TestFailed(e);
      }

      notifier.TestPassed();
    }
  }
}