using System.Collections.Generic;

namespace ConsoleApp {
    public interface IBaseCollection {
        void Add(object obj);
        void Remove(object obj);
        
    }

    public static class BaseCollectionExt {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects) {
            foreach (var item in objects) {
                collection.Add(item);
            }
        }
    }

     public class BaseList : IBaseCollection {
         public BaseList(int initialCapacity){}
         public void Add(object obj) {
             throw new System.NotImplementedException();
         }

         public void Remove(object obj) {
             throw new System.NotImplementedException();
         }
     }
}