### Prompt:
Elevator Project:
- Provide code that simulates an elevator. You are free to use any language.
- Upload the completed project to GitHub (public) for discussion during interview.
- Document all assumptions and any features that weren’t implemented.
- The result should be an executable, or script, that can be run with the following inputs and generate the following outputs.
  - Inputs: [list of floors to visit] (e.g. elevator start=12 floor=2,9,1,32)
  - Outputs: [total travel time, floors visited in order] (e.g. 560 12,2,9,1,32)
  - Program Constants: Single floor travel time: 10

### Notes:
- This implementation allows floor numbers from 0 to *int.MaxValue*.
- It is a Console app that reads on user input from the Console.  Output is also via the Console.
- Repeated floors are allowed (...9,5,5,6...), with 0 travel time registered.
- This project is built and run using Microsoft VS Code, using the 'C# Dev Kit' extension.
- Microsoft assures me that VS code will run in a Linux environment -- I have not tested it there.
- In the *...bin/Debug/net9.0/* folder is an executable (*Elevator.exe*) that runs on Windows
