# implement a CLI class
    - Make a CLI class that makes the program more dynamic when used in userspace.[x]
# extend the CLI class
    - Add support for more options when handling the JSON data for instance:
        - select only data on bosses
        - select only data on skills & ehp
        - check ONLY ehp
        - check ONLY boss activity
    - Try to figure out a more optimal way to handle the string[] args in ReadLine where we can select a[0] then a[1] where [index] refers to a substring/slice.
# unit-test the CLI
    - Add unit tests(Xunit)
        - Test cases:
            * Test the POST-endpoint
            * Test a PUT-endpoint
            * Test rate-limit(can the program be abused?)

# Implementing the MVC
    ##  
        * Working on creating all the relevant models, and properly assigning the correct datatypes, props & fields.
        * Architecture
            - Models (backend)
                - The models are predefined in the backend, no need for users to change these.
            - Controllers (frontend & backend)
                - Control how the models behave
            - View (frontend)
                - Spectre CLI frontend(optional)


# Tests
    ## Test-Library Xunit
        - Red/Green


# Build
    - Docker Compose?
    - Can .NET CORE software be shipped as a virtual enviorment?

#### Changelog
    ## Working on implementing MVC
    ## Working on implementing proper models
    