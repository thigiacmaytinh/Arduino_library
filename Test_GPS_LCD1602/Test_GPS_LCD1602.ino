#include <LiquidCrystal.h>
#include <SoftwareSerial.h>
#include <TinyGPS++.h>

LiquidCrystal lcd(8, 9, 4, 5, 6, 7);
// Create an instance of the TinyGPS object
TinyGPSPlus gps;
void getgps(TinyGPSPlus &gps);
void setup()
{
  Serial.begin(9600);
  lcd.begin(16, 2);
}
void getgps(TinyGPSPlus &gps)
// The getgps function will display the required data on the LCD
{
  float latitude, longitude;
  //decode and display position data
  latitude = gps.location.lat();
  longitude = gps.location.lng();
  lcd.setCursor(0,0);
  lcd.print("La:");
  lcd.print(latitude,1);
  lcd.print(" ");
  lcd.print("Lg:");
  lcd.print(longitude,1);
  
  lcd.print(" ");
//  ---------- Giờ ------------
  lcd.setCursor(0,1);
  lcd.print(gps.time.hour()+7);
  lcd.print(":");
  lcd.print(gps.time.minute());
  
  lcd.print("  ");
  
//  ---------- Ngày ------------
  lcd.print(gps.date.day());
  lcd.print("/");
  lcd.print(gps.date.month());
  lcd.print("/");
  lcd.print(gps.date.year()-2000);
  delay(3000); // wait for 3 seconds
  lcd.clear();
}
void loop()
{
  byte a;
  if ( Serial.available() > 0 ) // if there is data coming into the serial line
  {
    a = Serial.read(); // get the byte of data
    if(gps.encode(a)) // if there is valid GPS data...
    {
      getgps(gps); // grab the data and display it on the LCD
    }
  }
}
