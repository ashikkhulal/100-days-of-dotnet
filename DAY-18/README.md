## DAY-18

### Why namespaces:

- Namespaces are used to organize our programs.
- They also provide assistance in avoiding name clashes.

### Namespaces:

- Namespace is used to organize our code and can be collection of another namespace, classes, interfaces, structs, enums and delegates.
- Namespaces don't correspond to file, directory or assembly names. They could be written in separate files and / or separate assemblies and still belong to the same namespaces
- Namespaces can be nested in two ways:
  - using namespace alias directives: sometimes we may encounter a long namespace and wish to have it shorter. This could improve readability and still avoid name clashes with similar named methods.
  - using fully qualified names: this also helps in avoiding ambiguity but it will be longer.