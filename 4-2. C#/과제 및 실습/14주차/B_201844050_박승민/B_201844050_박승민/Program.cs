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
                if (menuInput.Equals("Q"))
                {
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
                    Product product = new Product(products.Count + 1, name, price, firstCount, disAccount);
                    Console.WriteLine($"상품번호:{product.Number} 이름:{product.Name} 단가:{product.UnitPrice} 재고수량:{product.StockCount} 할인율:{100 * product.DiscountRate}%");
                    products.Add(product);
                }
                else if (menuInput.Equals("B"))
                {
                    Console.Write("상품명:");
                    string name = Console.ReadLine();
                    foreach (var prod in products)
                    {
                        if (prod.Name.Equals(name))
                        {
                            Console.WriteLine("현재 재고:" + prod.StockCount);
                            Console.WriteLine("30개 이상 구매시 할인율:" + prod.DiscountRate);
                            Console.Write("추가 입고 수량 입력(1) 할인율 수정(2):");
                            int updateOption = int.Parse(Console.ReadLine());
                            if (updateOption == 1)
                            {
                                Console.Write("추가 재고 수량:");
                                prod.StockCountUp(int.Parse(Console.ReadLine()));
                                Console.WriteLine("현재 재고:" + prod.StockCount);
                            }
                            else if (updateOption == 2)
                            {
                                Console.Write("수정 할인율(예 10% -> 0.1 입력):");
                                prod.DiscountRate = double.Parse(Console.ReadLine());
                                Console.WriteLine($"변경 30개 이상 구매시 할인율:{100 * prod.DiscountRate}%");
                            }
                        }
                    }
                }
                else if (menuInput.Equals("C"))
                {
                    Console.Write("상품명:");
                    string name = Console.ReadLine();
                    foreach (var prod in products)
                    {
                        if (prod.Name.Equals(name))
                        {
                            Console.WriteLine("현재 재고:" + prod.StockCount);
                            Console.WriteLine($"30개 이상 구매시 할인율:{prod.DiscountRate}%");
                            Console.Write("판매 수량:");
                            int saleCount = int.Parse(Console.ReadLine());
                            Sale sale = new Sale(sales.Count+1,prod.Number, DateTime.Now,saleCount, prod.Sale(saleCount));
                            sales.Add(sale);
                            Console.WriteLine($"판매번호:{sale.Number} 상품이름:{prod.Name} 판매일자:{sale.Date.ToString("yyyy-MM-dd")} 판매수량:{sale.Count} 판매금액:{sale.Price}");
                        }
                    }
                }
                else if (menuInput.Equals("D"))
                {
                    foreach(var prod in sales)
                    {
                        Console.WriteLine($"총수량:{prod.Count}   [{prod.Price}]");
                    }
                }
            }
        }
    }
}
