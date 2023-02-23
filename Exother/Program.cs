using System.Linq;

var a = 12;       // Можно прописать int a = 12 но не стоит если проект большой лучше использовать var;
//Console.WriteLine(a.GetType().Name);

var data = new int[]{1,2,3,4}
         .Where(e=> e>0)
         .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType());        // Console.WriteLine(data.GetType().Name); 