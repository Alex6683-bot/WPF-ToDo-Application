using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using ToDo.MVVM.Models;

namespace ToDo.MVVM.Utilities
{
    static class TaskSerialization
    {
        public static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Tasks";
        public static readonly string SaveFileName = "SavedTasks.json";

        public static void Serialize(ObservableCollection<TaskObject> tasks)
        {
            Directory.CreateDirectory(Path);
            using (StreamWriter sw = new StreamWriter(Path + @"\" + SaveFileName))
            {
                sw.Write(JsonConvert.SerializeObject(tasks.ToList(), Formatting.Indented));
            }
        }

        public static ObservableCollection<TaskObject> Deserialize()
        {
            Directory.CreateDirectory(Path);
            using (StreamWriter sw = File.AppendText(Path + @"\" + SaveFileName)) { }
            using (StreamReader sr = new StreamReader(Path + @"\" + SaveFileName))
            {
                List<TaskObject> deserializedTasks = JsonConvert.DeserializeObject<List<TaskObject>>(sr.ReadToEnd());
                return new ObservableCollection<TaskObject>(deserializedTasks == null ? new() : deserializedTasks);
            }

        }
    }
}
