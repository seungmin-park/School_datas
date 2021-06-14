#include <Stepper.h>

#define IN1 8
#define IN2 9
#define IN3 10
#define IN4 11

const int stepsPerRevolution = 512;
int push = 2;

Stepper myStepper(stepsPerRevolution, IN4, IN2, IN3, IN1);
void setup() {
  // put your setup code here, to run once:
  pinMode(push,INPUT);
  myStepper.setSpeed(14);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(digitalRead(push) == HIGH){
    for(int i = 1; i <=4; i ++){
    myStepper.step(stepsPerRevolution);
  delay(500);
  }
  }else{
    for(int i = 1; i <=4; i ++){
    myStepper.step(-stepsPerRevolution);
  delay(500);
  }
  }
}
