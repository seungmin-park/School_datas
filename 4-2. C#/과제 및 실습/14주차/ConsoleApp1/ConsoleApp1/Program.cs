using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<Product> productList = new List<Product>();
        static List<Sale> saleList = new List<Sale>();
        static string path = "c:\\Fin201844050";
        static string fileProduct = "prduct.txt";
        static string fileSale = "sale.txt";


        static string[] menus =
        {
            "A. 상품 정보 입력",
            "B. 상품 정보 수정",
            "C. 판매 입력",
            "D. 통계",
            "",
            "Q. 종료",
        };

        static void Menu()
        {
            foreach (var menu in menus)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("-----------------------------");
            Console.Write(">");
        }
        static void Main(string[] args)
        {

            OpenDataList();
            while (true)
            {
                Menu();
                var inMenu = Console.ReadLine().Trim().ToUpper();

                if(inMenu == "Q")
                {
                    return;
                }

                switch(inMenu){
                    case "A":
                        InsertProduct();
                        break;
                    case "B":
                        UpateProduct();
                        break;
                    case "C":
                        InsertSale();
                        break;
                    case "D":
                        ViewData();
                        break;
                }
            }
        }

        private static void OpenDataList()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filename = string.Empty;
            //product.txt
            filename = Path.Combine(path, fileProduct);
            if (File.Exists(filename))
            {
                using (var sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        string data = sr.ReadLine();//record
                        string[] splitData = data.Split(',');

                        if(splitData.Length == 5)
                        {
                            try
                            {
                                var number = int.Parse(splitData[0]);
                                var name = splitData[1];
                                var price = int.Parse(splitData[2]);
                                var stock = int.Parse(splitData[3]);
                                var discount = double.Parse(splitData[4]);

                                productList.Add(new Product(number, name, stock, price, discount));
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }
            //sale.txt
            filename = Path.Combine(path, fileSale);
            if (File.Exists(filename))
            {
                using (var sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        string data = sr.ReadLine();//record
                        string[] splitData = data.Split(',');

                        if (splitData.Length == 5)
                        {
                            try
                            {
                                int number = int.Parse(splitData[0]);
                                int prodNumber = int.Parse(splitData[1]);

                                int year = int.Parse(splitData[2].Substring(0,4));
                                int month = int.Parse(splitData[2].Substring(4, 2));
                                int day = int.Parse(splitData[2].Substring(6, 2));
                                DateTime date = new DateTime(year, month, day);

                                int count = int.Parse(splitData[3]);
                                int price = int.Parse(splitData[4]);

                                saleList.Add(new Sale(number, prodNumber, date, count, price));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private static void ViewData()
        {
            for (int i = 0; i < productList.Count; i ++){
                int totalcnt = 0;
                int totalprice = 0;

                for(int j = 0; j < saleList.Count; j++)
                {
                    if(saleList[j].ProdNumber == productList[i].Number)
                    {
                        totalcnt += saleList[j].Count;
                        totalprice += saleList[j].Price;
                    }
                }

                Console.WriteLine($"총 수량:{totalcnt,10} 총 판매액:{totalprice,10} [{productList[i].Name}]");
            }
        }

        private static void InsertSale()
        {
            string name;
            int count;
            Product searchProduct = null;
            try
            {

                Console.Write("상품명:");
                name = Console.ReadLine();
                searchProduct = productList.FirstOrDefault(m => m.Name == name);
                if (searchProduct == null)
                {
                    Console.WriteLine("상품 정보 없음");
                    return;
                }

                Console.WriteLine($"현재 재고 : {searchProduct.StockCount}");
                Console.WriteLine($"30개 이상 구매시 할인율 : {searchProduct.DiscountRate * 100}%");

                Console.Write("판매수량:");
                count = int.Parse(Console.ReadLine());

                var sale = new Sale(saleList.Count, searchProduct.Number, DateTime.Now, count, searchProduct.Sale(count));
                saleList.Add(sale);
                Console.WriteLine($"판매번호:{sale.Number} 상품이름:{searchProduct.Name} 판매일자:{sale.Date.ToString("yyyy-MM-dd")} 판매수량:{sale.Count} 판매금액:{sale.Price}");


                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var fileName = Path.Combine(path, fileSale);

                using (var sw = new StreamWriter(new FileStream(fileName, FileMode.Append),Encoding.UTF8))
                {
                    sw.WriteLine($"{sale.Number.ToString("000000")},{sale.ProdNumber.ToString("000000")},{sale.Date.ToString("yyyyMMdd")},{sale.Count.ToString("00000000")},{sale.Price.ToString("0000000000")}");
                }

                var filename = Path.Combine(path, fileSale);
                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        int pos = 0;
                        while (!sr.EndOfStream)
                        {
                            var data = sr.ReadLine();

                            if (0 == data.IndexOf(searchProduct.Number.ToString("000000")))
                            {
                                var seekpos = pos + Encoding.UTF8.GetByteCount(data) - Encoding.UTF8.GetByteCount("000000,00.00");

                                fs.Seek(seekpos, SeekOrigin.Begin);

                                var wdata = Encoding.UTF8.GetBytes(searchProduct.StockCount.ToString("000000"));
                                fs.Write(wdata, 0, wdata.Length);

                                break;
                            }

                            pos += Encoding.UTF8.GetByteCount(data) + Environment.NewLine.Length;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            }

        private static void UpateProduct()
        {

            string name;
            string inputSel;
            int count;
            double discount;
            Product searchProduct = null;
            try
            {

                Console.Write("상품명:");
                name = Console.ReadLine();

                //foreach (var prod in productList)
                //{
                //    if (prod.Name == name)
                //    {
                //        Console.WriteLine($"단가:{prod.UnitPrice}");
                //    }
                //}
                searchProduct = productList.FirstOrDefault(m => m.Name == name);
                if (searchProduct == null)
                {
                    Console.WriteLine("상품 정보 없음");
                    return;
                }

                Console.WriteLine($"현재 재고 : {searchProduct.StockCount}");
                Console.WriteLine($"30개 이상 구매시 할인율 : {searchProduct.DiscountRate*100}%");
                Console.Write("추가 입고 수량 입력(1) 할인율 수정(2):");
                inputSel = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(inputSel))
                {
                    return;
                }
                //재고수량 변경
                if(inputSel == "1")
                {
                    try
                    {
                        Console.Write("추가 재고 수량 : ");
                        count = int.Parse(Console.ReadLine());

                        searchProduct.AddStockCount(count);
                        Console.WriteLine($"현재 재고 : {searchProduct.StockCount}");

                        var filename = Path.Combine(path, fileProduct);
                        using (var fs = new FileStream(filename, FileMode.Open))
                        {
                            using (var sr = new StreamReader(fs, Encoding.UTF8))
                            {
                                //한줄씾ㄱ읽으면서,원하는제품을찾기
                                int pos = 0;
                                while (!sr.EndOfStream)
                                {
                                    var data = sr.ReadLine();

                                    if (0 == data.IndexOf(searchProduct.Number.ToString("000000")))
                                    {
                                        var seekpos = pos + Encoding.UTF8.GetByteCount(data) - Encoding.UTF8.GetByteCount("000000,00.00");

                                        fs.Seek(seekpos, SeekOrigin.Begin);

                                        var wdata = Encoding.UTF8.GetBytes(searchProduct.StockCount.ToString("000000"));
                                        fs.Write(wdata, 0, wdata.Length);

                                        break;
                                    }

                                    pos += Encoding.UTF8.GetByteCount(data) + Environment.NewLine.Length;
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                //할인율변경
                else if(inputSel == "2")
                {
                    try
                    {
                        Console.Write("수정 할인율(예:10% -> 0.1입력) : ");
                        discount = double.Parse(Console.ReadLine());

                        searchProduct.DiscountRate = discount;
                        Console.WriteLine($"변경 30개 이상 구매시 할인율 : {searchProduct.DiscountRate*100}%");

                        var filename = Path.Combine(path, fileSale);
                        using(var fs = new FileStream(filename, FileMode.Open))
                        {
                            using (var sr = new StreamReader(fs, Encoding.UTF8))
                            {
                                int pos = 0;
                                while (!sr.EndOfStream)
                                {
                                    var data = sr.ReadLine();

                                    if (0 == data.IndexOf(searchProduct.Number.ToString("000000")))
                                    {
                                        var seekpos = pos + Encoding.UTF8.GetByteCount(data) - Encoding.UTF8.GetByteCount("00.00");

                                        fs.Seek(seekpos, SeekOrigin.Begin);

                                        var wdata = Encoding.UTF8.GetBytes(searchProduct.DiscountRate.ToString("00.00"));
                                        fs.Write(wdata, 0, wdata.Length);
    
                                    break;
                                    }

                                    pos += Encoding.UTF8.GetByteCount(data) + Environment.NewLine.Length;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private static void InsertProduct()
        {
            Console.Write("상품명:");
            string name = Console.ReadLine();
            Console.Write("단가:");
            if (!int.TryParse(Console.ReadLine(), out int price))
            {
                return;
            }
            Console.Write("초기수랑:");
            if(!int.TryParse(Console.ReadLine(), out int count)){
                return;
            }
            Console.Write("30개 이상 구매시 할인율 (예: 10% -> 0.1입력):");
            if(!double.TryParse(Console.ReadLine(), out double discount)){
                return;
            }

            Product product = new Product(productList.Count, name, count, price, discount);
            productList.Add(product);
            Console.WriteLine($"상품번호:{product.Number} 이름:{product.Name} 단가:{product.UnitPrice} 재고수량:{product.StockCount} 할인율:{product.DiscountRate * 100}%");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var fileName = Path.Combine(path, fileProduct);
            using (var sw = new StreamWriter(new FileStream(fileName, FileMode.Append), Encoding.UTF8))//이거 다시 한번 확인하기
            {
                sw.WriteLine($"{product.Number.ToString("000000")}," +
                    $"{product.Name}," +
                    $"{product.UnitPrice.ToString("000000")}," +
                    $"{product.StockCount.ToString("000000")}," +
                    $"{product.DiscountRate.ToString("00.00")}");
            }

        }
    }
}
