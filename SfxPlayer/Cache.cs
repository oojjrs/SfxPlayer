using LiteDB;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SfxPlayer
{
    public static class Cache
    {
        private struct Folder
        {
            [BsonId]
            public string Path { get; set; }
        }

        private static LiteDatabase _db;

        public static void ClearDirties()
        {
            var col = _db.GetCollection<Folder>("dirties");
            col.DeleteAll();
        }

        public static void Initialize(string root)
        {
            _db = new LiteDatabase($"{Path.Combine(root, "Cache.db")}");
        }

        public static IEnumerable<string> SelectAll()
        {
            var col = _db.GetCollection<Folder>();
            return col.FindAll().Select(t => t.Path);
        }

        public static IEnumerable<string> SelectAllDirties()
        {
            var col = _db.GetCollection<Folder>("dirties");
            return col.FindAll().Select(t => t.Path);
        }

        public static void Upsert(string path)
        {
            var col = _db.GetCollection<Folder>();
            if (col.Upsert(new Folder() { Path = path }))
            {
                col.EnsureIndex(t => t.Path);

                var col2 = _db.GetCollection<Folder>("dirties");
                col2.Insert(new Folder() { Path = path });
            }
        }
    }
}
