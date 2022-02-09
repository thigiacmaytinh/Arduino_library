/*
 * Kết nối:
 *          DHT                   Arduino
 *          VCC                     5V
 *          GND                     GND
 *         Tín hiệu                  2
 *         
 * Tùy chọn tên của cảm biến cho phù hợp
 * Nạp code mở Serial Monitor, chọn No line ending, baud 9600
 * 
 * 
 * 
 * 
 * 
 */
#include "DHT.h"

#define DHTPIN 2     // what digital pin we're connected to

// Chọn loại cảm biến cho phù hợp ---------------------------------------------------------------------------------------
//#define DHTTYPE DHT11   // DHT 11
//#define DHTTYPE DHT22   // DHT 22  (AM2302), AM2321
#define DHTTYPE DHT21   // DHT 21 (AM2301)


DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  Serial.println("DHTxx test!");

  dht.begin();
}

void loop() {
  // Wait a few seconds between measurements.
  delay(2000);

  // Reading temperature or humidity takes about 250 milliseconds!
  // Sensor readings may also be up to 2 seconds 'old' (its a very slow sensor)
  float h = dht.readHumidity();
  // Read temperature as Celsius (the default)
  float t = dht.readTemperature();
  // Read temperature as Fahrenheit (isFahrenheit = true)
  float f = dht.readTemperature(true);

  // Check if any reads failed and exit early (to try again).
  if (isnan(h) || isnan(t) || isnan(f)) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }

  // Compute heat index in Fahrenheit (the default)
  float hif = dht.computeHeatIndex(f, h);
  // Compute heat index in Celsius (isFahreheit = false)
  float hic = dht.computeHeatIndex(t, h, false);

  Serial.print("Humi: ");
  Serial.print(h);
  Serial.print("%   ");
  Serial.print("Temp: ");
  Serial.print(t);
  Serial.print("*C ");
  Serial.print(f);
  Serial.print("*F ");
  Serial.print("Heat index: ");
  Serial.print(hic);
  Serial.print("*C ");
  Serial.print(hif);
  Serial.println(" *F");
}
