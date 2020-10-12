I've been experimenting with Blazor and noticed an issue with API Calls exected in parallel. 

The solution contains two templated projects with a few little changes.

**Case 1:**
WebAssembly constructs 10 parallel requests to API. API does 500ms delay and returns "Hello {DateTime.Now}"
WebAssembly computes total execution time in ms.

Expected behaviour is to see the requests actually exectuted in parallel so the total time to be lower than 5000ms. 
Fails is Developer Tools are closed.

**Case 2:**
WebAssembly executes 10 tasks with Delay(500ms)
WebAssembly computes total execution time in ms.

Expected behaviour is to see total execution time around 500ms - **works**

API Calls executed in Chrome:
![Chrome API Call](/Screenshots/Chrome1.png)

Delay executed in Chrome:
![Delay](/Screenshots/Chrome2.png)

API Calls executed in Chrome with Dev Tools:
![Chrome API Call DT](/Screenshots/Chrome3.png)

Delay executed in Chrome in Chrome with Dev Tools:
![Delay DT](/Screenshots/Chrome4.png)
