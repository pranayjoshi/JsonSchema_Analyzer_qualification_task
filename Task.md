## Introduction

Thank you for expressing your interest in this Google Summer of Code (GSoC) 2024 project.  If selected, your contributions will help make API development simpler for .Net developers everywhere.

## Qualifying Task

To qualify for this project, we ask that you perform the tasks below.  A .Net solution has been provided to get you started.

In this solution there are three projects: _CorvusQualification_, _ExistingLibrary_, _UserCode_.

1. _CorvusQualification_ does not compile because it uses an attribute that does not exist.  Your first task is to update _ExistingLibrary_ by adding an incremental source generator that produces the missing attribute.  Once the solution compiles this task is complete.
2. Update _ExistingLibrary_ to produce a nuget package that, once installed, allows the user to use `ServiceProvider` _and_ generates the attribute.  Install this package into _UserCode_ and use the attribute as shown in _CorvusQualification_.
   > **IMPORTANT** _UserCode_ must not contain a project reference to _ExistingLibrary_; it must consume the nuget package.
3. Write a readme for the project describing how a user would install the _ExistingLibrary_ nuget package and make use of the attribute.