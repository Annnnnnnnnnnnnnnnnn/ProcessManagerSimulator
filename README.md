# ProcessManagerSimulator
A custom simulation of process manager written on C#
## DESCRIPTION
### Brief description
A test of implementing the basic work mechanic of processes managers (not actually implementing them).  
This is basically the Foreground Background algorithm. It suggests we have N queues. There the processes will be put on creating. 
Each process has a number associated with it, based on the actual order of the task appearance.
### FUNCTIONS 

We have `class Time` - simulator of clock, that contains methods:  `inc_min()`(increasing minutes), `inc_sec()`(increasing seconds), `inc_msec()`(increasing miliseconds)
We have `class Process` - simulator of process, that has such properties:`id`, `complexity`, `start`, `finish`, `time_worked`, `deleyed`, `state`. There can be many values of state like: 0 - default value, when process just created, 1 - process run or resume, 2 - process paused, 3 - process solved.
We have `ProcessGenerator class` thar creates new Processes by using random
In `ProcessManager class` we have `List<Process> processes_queue` (it is the queue of processes that wait to be done), `BindingList<Process> done_processes `(list of done processes) ,`run_next()` (method for solve process),  `gen_next()`(add new process to processes_queue list ), `all_done() `(check if all processes are done)
  
 
## DEMONSTRATION

