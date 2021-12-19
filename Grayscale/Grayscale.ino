int pinSensor = A0;

void setup() 
{
  pinMode(pinSensor, INPUT);
  Serial.begin(9600);
}
void loop() 
{
  Serial.println(analogRead(pinSensor));
  delay(100);
}
