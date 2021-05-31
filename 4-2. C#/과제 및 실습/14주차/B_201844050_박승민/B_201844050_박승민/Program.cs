using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_201844050_박승민
{
    class Program
    {
        static void Main(string[] args)
        {
        List<Product> products = new List<Product>();
        List<Sale> sales = new List<Sale>();
            string menuInput;
            while (true)
            {
                Console.WriteLine("--------메뉴-------");
                Console.WriteLine("A. 상품 정보 입력");
                Console.WriteLine("B. 상품 정보 수정");
                Console.WriteLine("C. 판매 입력");
                Console.WriteLine("D. 통계\n");
                Console.WriteLine("Q. 종료");
                Console.WriteLine("-------------------");
                Console.Write(">");
                menuInput = Console.ReadLine();
                if (menuInput.Equals("Q")){
                    break;
                }
                else if (menuInput.Equals("A"))
                {
                    Console.Write("상품명:");
                    string name = Console.ReadLine();
                    Console.Write("단가:");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("초기수량:");
                    int firstCount = int.Parse(Console.ReadLine());
                    Console.Write("30개 이상 구매시 할인율(예 : 10% -> 0.1 입력):");
                    double disAccount = double.Parse(Console.ReadLine());
                    Product product = new Product(name, price,firstCount,disAccount);
                    Console.WriteLine($"상품번호:{1} 이름:{product.Name} 단가:{product.UnitPrice} 재고수량:{product.StockCount} 할인율:{product.DiscountRate*100}%");
                    products.Add(product);
                }
            }
        }
    }
}
