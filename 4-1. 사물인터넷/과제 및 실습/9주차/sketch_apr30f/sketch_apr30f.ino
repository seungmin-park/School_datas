#include <Servo.h>
Servo myServo;
int angle = 90;
void setup() {
  // put your setup code here, to run once:
  myServo.attach(12);
}

void loop() {
  // put your main code here, to run repeatedly:
  for(angle =0; angle <= 180; angle += 1){
    myServo.write(angle);
    delay(15);
  }
  for(angle= 180; angle >= 0; angle-=1){
    myServo.write(angle);
    delay(15);
  }
}
