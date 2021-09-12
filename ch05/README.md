
# NOTE:
We split class PERSON into 2 files.

We use "public partial class Person" in both file.
They may have many different attributes and methods but can only have 1 constructor.

# TO FORMAT a STRING
WriteLine(format: 
        "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
        arg0: gunny.Name,
        arg1: gunny.HomePlanet,
        arg2: gunny.Instantiated);
