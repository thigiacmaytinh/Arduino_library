int pinSensor = 2;
int pinRelay = 8;

bool hasSent = false;

void setup() {
  pinMode(pinSensor, INPUT_PULLUP);
  pinMode(pinRelay, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  int value = digitalRead(pinSensor);
  if(value == HIGH)
  {
    if(!hasSent)
    {
      int calledTime = millis() / 1000;
      Serial.println("Item appear " +  String(calledTime)); 
      TriggerRelay(1);
      hasSent = true;
    }
  }
  else
  {
    hasSent = false;
  }
  
  delay(20);
}
 
void TriggerRelay(int ms)
{
  digitalWrite(pinRelay, LOW);
  delay(ms);
  digitalWrite(pinRelay, HIGH);
}
