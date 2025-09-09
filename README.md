# Instructions

Build a C# console application that provides insight into a household’s energy 
consumption and costs. The application should read data, perform calculations, 
and present a clear overview. When submitting, only hand in your `.cs` file, 
not the entire project.

Once you’re finished, have your code reviewed by an LLM (ChatGPT, Copilot, etc.).  
Ask it to look at your code critically and help you improve it.  
Although tempting: **write the code yourself!**

---

## Program Requirements

### 1. Collect Data for 3 Devices:
Ask the user for the following information about three different household devices:
- The name of the device (e.g., "Refrigerator").  
- The power in Watts.  
- The average number of hours used per day.  

### 2. Calculate Consumption:
- For each device, calculate the daily energy consumption in kilowatt-hours (kWh).  
- Calculate the total daily consumption by summing the three devices.  

### 3. Cost Calculation and Presentation:
- Define a fixed electricity price in your program (e.g., €0.25 per kWh).  
- Based on the total consumption, calculate the costs for:  
  - One day  
  - One month (start simple: 30 days per month)  
  - One year (365 days)  
- Display all calculated costs clearly in the console, with clear labels.  

---

## Bonus Challenges

If you finish early, expand the application with one or more of the following features:

- **CO₂ Emissions:**  
  Calculate the yearly CO₂ emissions based on total consumption (use 427 grams 
  CO₂ per kWh) and display the result in kilograms.  

- **Daytime/Nighttime Tariff:**  
  Implement a separate peak and off-peak tariff.  
  Ask the user to specify the hours per device for both tariffs and calculate the 
  costs more accurately.  

- **Clean Presentation:**  
  Pay extra attention to the console user interface (including colors).  
  Use blank lines and text dividers to make the question-answer sessions and the 
  final report look professional.
