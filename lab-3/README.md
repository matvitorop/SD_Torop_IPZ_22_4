# Software design Lab №3 
## Author: Torop Matvii, IPZ-22-4

- This lab was maded to use structural patterns of programming, that can make a code more readable and cleaner
- All patterns was separated on their own libary of classes
- So `patterns of programming`, with which I worked:
  - [x] **Adapter**
  - [ ] **Decorator**
  - [ ] **Bridge**
  - [ ] **Proxy**
  - [ ] **Composer**
  - [ ] **LightWeight**
### Adapter
This pattern must make `target class` (old class) and `adaptee class` (new class) adjacent to each other. It useful when they have different data types. I made target class [Logger](./Adapter/Logger.cs) , that print in console text with different context and color. Then, I made [FileWriter](./Adapter/FileWriter.cs) that working as commands `Write` and `WriteLine` on C#. After this, i made [FileWriterAdapter](./Adapter/FileWriterAdapter.cs) that `imatates Logger` and takes `FileWriter as a field`. In the end, I overriding methods from `Logger`, combining them with `FileWriter` methods and adding [old functionality](./Adapter/FileWriterAdapter.cs#L22) for example.  
