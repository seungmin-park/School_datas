// package main

// import (
// 	"fmt"
// 	"time"
// )

// func a() {
// 	for i:=0; i<20; i++ {
// 		fmt.Print("A")
// 	}
// }

// func b() {
// 	for i:=0; i<20; i++ {
// 		fmt.Print("B")
// 	}
// }

// func c() {
// 	fmt.Println("C")
// }

// func d() {
// 	fmt.Println("D")
// }

// func main() {
// 	go a()
// 	go b()
// 	defer c() //defer = main 함수의 stack이 소멸되기 직전에 실행되고 종료.
// 	defer d() //defer들을 stack에 담기 때문에 d가 먼저 poped out.
// 	time.Sleep(time.Second*2)
// 	fmt.Println("main end...")
// }

package main

import (
	"fmt"
	"io/ioutil"
	"log"
	"net/http"
	"time"
)

func responseSize(url string, channel chan WebPage) {
	res, e := http.Get(url)
	if e != nil {
		log.Fatal(e)
	}
	defer res.Body.Close()

	body, e := ioutil.ReadAll(res.Body)
	if e != nil {
		log.Fatal(e)
	}

	channel <- WebPage{URL: url, Size: len(body)}
}

type WebPage struct {
	URL string
	Size int
}

func main()  {
	urls := []string{
		"http://www.inhatc.ac.kr",
		"http://www.harvard.edu",
		"http://www.naver.com",
		"http://www.daum.net"}

	pages := make(chan WebPage)

		for _, url := range urls {
			go responseSize(url,pages)
		}
		time.Sleep(time.Second *3)

		for i := 0; i < len(urls); i++ {
			page := <- pages
			fmt.Printf("%s : %d\n",page.URL, page.Size)
		}

	}

	

// package main

// import (
// 	"fmt"
// 	"io/ioutil"
// 	"log"
// 	"net/http"
// )


// func main()  {
// 	res, e := http.Get("https://www.inhatc.ac.kr")
// 	if e != nil {
// 		log.Fatal(e)
// 	}
// 	defer res.Body.Close()

// 	body, e := ioutil.ReadAll(res.Body)
// 	if e != nil {
// 		log.Fatal(e)
// 	}
// 	fmt.Println(string(body))
// 	}