using System.Globalization;
using System.Text;
using System.Collections.Concurrent;

namespace EstudosGerais.Exemplos
{
    internal class ExamplesBooks
    {
        #region Propriedades

        public int Id { get; set; }
        public string? Name { get; set; }
        
        #endregion

        #region Métodos

        #region String
        public int CountCaracters(string text)
        {
            int quantityCaractersString = 0;

            if (string.IsNullOrEmpty(text.Trim()))
                return 0;

            quantityCaractersString = (text.Trim()).Length > 0 ? (text.Trim()).Length : 0;

            return quantityCaractersString;
        }

        public int CountCaractersSecond(string text)
        {
            int quantityCaractersString = 0;

            if (string.IsNullOrEmpty(text.Trim()))
                return 0;

            quantityCaractersString = text.Replace(" ", "").Length > 0 ? text.Replace(" ", "").Length : 0;

            return quantityCaractersString;


        }

        public byte[] ConvertStringToUtfEigth(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);

            return data;
        }

        public string ConvertUtfEigthToString(byte[] data)
        {
            string text = Encoding.UTF8.GetString(data);

            return text;
        }

        public int CountCaractersOcourrences(string text)
        {
            int quantityCaractersString = 0;

            if (string.IsNullOrEmpty(text.Trim()))
                return 0;

            quantityCaractersString = text.Count(x => x == 'k');

            return quantityCaractersString;
        }

        public string RemovingCaracterToIndex(int indexIni, int indexEnd, string text)
        {
            string newString = string.Empty;

            newString = text.Remove(indexIni, indexEnd);

            return newString;
        }

        public string WorkingInSubString(string text, string textAppend)
        {
            StringBuilder sb = new StringBuilder(text);

            sb.AppendFormat("**** {0}", textAppend);

            return sb.ToString();
        }
        #endregion

        #region DateTime
        public string DatetimeParseExact(string text)
        {
            DateTime date = DateTime.ParseExact(text, "yyyy-MM-dd", null);
            return string.Format("{0} - Valor DateTime.ParseExact yyyy-MM-dd: ", date).ToString();
        }

        public string DatetimeParseExactCultureInfo(string text)
        {
            DateTime date = DateTime.ParseExact(text, "yyyy-MM-dd", new CultureInfo("en-US"));
            return string.Format("{0} - Valor DateTime.ParseExact yyyy-MM-dd: ", date).ToString();
        }

        public string DatetimeParseExactOnFormatString()
        {
            DateTime date = DateTime.ParseExact("04|202103", "dd|yyyyMM", null);
            return string.Format("{0} - Valor DateTime.ParseExact dd|yyyyMM: ", date).ToString();
        }

        public string DatetimeParseExactOnFormatStringII()
        {
            DateTime date = DateTime.ParseExact("2021|03|04", "yyyy|MM|dd", null);
            return string.Format("{0} - Valor DateTime.ParseExact yyyy|MM|dd: ", date).ToString();
        }




        #endregion

        #region Dictionaries

        public void DictionaryCollectionInitializer()
        {
            //Initialize a dictionary with a collection initialize
            //O exemplo abaixo pode ser da seguinte forma: dict.Add(1, "First"); ...
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "First" },
                {2, "Second" },
                {3, "Third" }
            };
            //O exemplo abaixo pode ser da seguinte forma: dict[1] = "First"; ...
            Dictionary<int, string> dictSecond = new Dictionary<int, string>()
            {
                [1] = "First",
                [2] = "Second",
                [3] = "Third"
            };

            foreach (var dct in dict)
            {
                Console.WriteLine(dct);
            }

            foreach (var dctSecond in dictSecond)
            {
                Console.WriteLine(dctSecond);
            }
        }

        public Dictionary<int, string> DictionaryCollectionAddInCheck()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            if (!dict.ContainsKey(1))
                dict.Add(1, "First");
            if (!dict.ContainsKey(2))
                dict[2] = "Second";

            return dict;
        }

        public void DictionaryCollectionConcurrent()
        {
            var dict = new ConcurrentDictionary<int, string>();

            dict.TryAdd(1, "First"); //retorna um bool caso consiga inserir;
            dict.GetOrAdd(2, "Second"); //tenta obter a chave/valor e se não existir, inseri;

            dict.AddOrUpdate(1, "First", (i, s) => "OK"); //key, valor, (tipos do dicionario) => novo valor "OK";

            foreach (var dct in dict)
            {
                Console.WriteLine(dct);
            }

        }

        public void IEnumerableToDict()
        {
            var example = new[]
            {
                new ExamplesBooks {Id = 1, Name = "First"},
                new ExamplesBooks {Id = 2, Name = "Second"}
            };

            var dict = example.ToDictionary(x => x.Id, x => x.Name);

            foreach (var dct in dict)
            {
                Console.WriteLine(dct);
            }
        }

        public void EnumerateDict()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            //Duas formas de Adição
            dict.Add(1, "First");
            dict[2] = "Second";

            //KeyValuePair
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key.ToString() + " " + kvp.Value.ToString());
            }

            //Keys
            foreach (int key in dict.Keys)
            {
                Console.WriteLine(key.ToString() + " " + dict[key].ToString());
            }

            //Values
            foreach (string value in dict.Values)
            {
                Console.WriteLine("value: " + value);
            }


        }

        public void DictionaryToList()
        {
            //Create List key/value
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "First");
            dict.Add(2, "Second");
            dict.Add(3, "Third");

            List<KeyValuePair<int, string>> lst = new List<KeyValuePair<int, string>>();
            lst.AddRange(dict);

            foreach (var lt in lst)
            {
                Console.WriteLine(lt);
            }

            //Create List key
            List<int> lstKey = new List<int>();
            lstKey.AddRange(dict.Keys);

            foreach (var ltk in lstKey)
            {
                Console.WriteLine(ltk);
            }

            //Create List value
            List<string> lstValue = new List<string>();
            lstValue.AddRange(dict.Values);

            foreach (var lstv in lstValue)
            {
                Console.WriteLine(lstv);
            }

        }

        public bool RemovingFromDictionary(int key)
        {
            bool retorno = false;

            Dictionary<int, string> dict = new Dictionary<int, string>() {
                {1, "First" },
                {2, "Second" }
            
            };

            if (dict.ContainsKey(key))
            {
                dict.Remove(key);
                retorno = true;
            }          

            return retorno;
        }

        #endregion

        #region Collections

        //Stack
        public void StackExamples()
        {
            //Stack (pilha) é uma collection para gerenciar valores na Stack que usa o principio LIFO (last-in first-out);
            Stack<string> stck = new Stack<string>();
            stck.Push("Calvino"); //Add elemento com o Push;
            stck.Push("Larissa"); //Add elemento com o Push;
            stck.Pop(); //Remove o último elemento da lista e retorna o objeto acima;
            stck.Push("Michael");
            
            foreach (string stk in stck)
            {
                Console.WriteLine(stk);
                Console.WriteLine(stck.Peek()); //pega o último elemento da lista, mas sem remove-lo;
            }
            
        }



        #endregion

        #endregion
    }

    #region Struct
    struct Produto
        {
        //Construtor
            public Produto(int id, string? name, EValidade estadoAtual = EValidade.Default)
            {
                Id = id;
                Name = name;
                EstadoAtual = estadoAtual;
            }

            public int Id { get; set; }
            public string? Name { get; set; }
            public EValidade EstadoAtual { get; set; }


        public string DscProduto(int id, string? name)
            {
                return string.Format("Id: {0}, Nome: {1}.", id, name);
            }

        }
    #endregion

    #region Enumerable

    //Enumerable
    enum EValidade
    {
        //Enumeradores
        NaValidade = 1,
        Vencido = 2,
        ND = 3,
        Default = 0
    }

    #endregion

}
