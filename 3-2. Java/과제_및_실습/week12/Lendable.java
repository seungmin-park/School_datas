package week12;

public interface Lendable {
    public byte STATE_BORROWED = 1;
    public byte STATE_NOMAL = 0;

    void checkOut(String person,String date);
    void checkIn();
}
