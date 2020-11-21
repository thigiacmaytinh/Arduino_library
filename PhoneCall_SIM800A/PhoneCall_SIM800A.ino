#include<SoftwareSerial.h>
SoftwareSerial SIM(2, 3);

bool hasCalled = false;

void setup() {
  Serial.begin(9600);
  SIM.begin(9600);
}

void loop() {
  if(!hasCalled)
  {
    hasCalled = true;
    
    Call("+84939825125");
    //SendSMS("+84939825125", "Day la tin nhan tu thigiacmaytinh.com");
  }

  delay(1000);
}

void Call(String number)
{
  Serial.println("   Start call");
  SIM.println("AT");
  SIM.println("ATD+ " + number + ";");
  delay(20000);
  
  SIM.println("ATH");   // kết thúc cuộc gọi
  delay(1000);
  Serial.println("   End call");
}

void SendSMS(String number, String content)
{
  Serial.println("   Start sms " + number + " at: " + String(millis()));
  SIM.println("AT");
  delay(100);
  SIM.println("AT+CMGF=1");
  delay(100);
  SIM.println("AT+CMGS=\"" + number + "\"");
  delay(1000);
  SIM.print(content);
  delay(100);
  SIM.print((char)26);
  delay(500);
  SIM.println();
  delay(5000);
  Serial.println("   End sms at: " + String(millis()));
}
