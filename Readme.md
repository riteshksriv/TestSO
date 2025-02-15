This file contains the relevant code to repro the issue.
The Get and Get2 methods just call nested 90 methods and for Get method,it just throws exception
For Get2 where I have used ConfigureAwait(false) it throws stackoverflow exception

```WebApplication1\Controllers\ValuesController.cs```