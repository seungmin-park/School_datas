package week7;

public class PetEx {
    public static void main(String[] args) {
        
        Pet pet1 = new Pet("강이지",8);
        Pet pet2 = new Pet("고양이",8);
        Pet pet3 = new Pet("새",8);
        System.out.println(pet1.type + "는 "+pet1.age+"개월입니다.");
        System.out.println(pet2.type + "는 "+pet2.age+"개월입니다.");
        System.out.println(pet3.type + "는 "+pet3.age+"개월입니다.");
        System.out.println();

        pet1.leg = 4;
        pet3.leg= 2;
        pet2.leg = 4;
        System.out.println(pet1.type + "다리는 "+pet1.leg+"개입니다.");
        System.out.println(pet2.type + "다리는 "+pet2.leg+"개입니다.");
        System.out.println(pet3.type + "다리는 "+pet3.leg+"개입니다.");
    }
}
