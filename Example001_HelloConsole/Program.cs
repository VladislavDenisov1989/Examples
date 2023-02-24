//Console.WriteLine("Hello, World!");

int n = 1;
void FindWords (string alphadet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphadet.Length; i++)
    {
        word[length] = alphadet[i];
        FindWords(alphadet, word, length + 1);
    }
}
//FindWords("аисв", new char[5]);



//string path = "C:/Users/emin/OneDrive/Рабочий стол/Examples/Example002_HelloUser";
//DirectoryInfo di = new DirectoryInfo(path);
//System.Console.WriteLine(di.CreationTime);
//FileInfo[] fi = di.GetFiles();

//for (int i = 0; i < fi.Length; i++)
//{
    //System.Console.WriteLine(fi[i].Name);
//}





//void CatalogInfo(string path, string indent = "")
//{
    //DirectoryInfo catalog = new DirectoryInfo(path);

    //DirectoryInfo[] cataLog = catalog.GetDirectories();
    //for (int i = 0; i < catalog.Length; i++)
    //{
        //Console.WriteLine($"{indent}{cataLog[i].Name}");
        //CatalogInfo(cataLog[i].FullName, indent + " ");
    //}

    //FileInfo[] files = catalog.GetFiles();

    //for (int i = 0; i < files.Length; i++ )
    //{
        //Console.WriteLine($"{indent}{files[i].Name}");
    //}
//}
//string path = 
//CatalogInfo(path);



//void Towers(string with ="1", string on = '3', string some = "2", int count =3)
//{
    //if (count > 1) Towers(with, some, on, count - 1);
    //Console.WriteLine($"{with} >> {on}");
    //if (count > 1) Towers(some, on, with, count - 1);
//}

//Towers();


string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "_", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();