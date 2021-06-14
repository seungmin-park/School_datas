package week12;

public class Book implements Lendable{
    String bookNo;
    String title;
    String writer;
    String person;
    String checkDate;
    byte state;

    public Book(String bookNo, String title, String writer){
        this.bookNo = bookNo;
        this.title = title;
        this.writer = writer;
    }

    @Override
    public void checkOut(String person, String date){
        if(state == Lendable.STATE_BORROWED){
            System.out.println("이미 대출된 도서 입니다.");
        return;
        }

        this.person = person;
        this.checkDate = date;
        this.state = Lendable.STATE_BORROWED;

        System.out.println("* "+title+" 도서가 대출되었습니다.");
        System.out.println("대출인 : " + person);
        System.out.println("대출일 : "+ checkDate);
    }



    @Override
    public void checkIn(){
        this.person = null;
        this.checkDate = null;
        this.state = Lendable.STATE_NOMAL;
        System.out.println("▶" + title +" 도서가 반납되었습니다.");
    }
}
