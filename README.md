# CPExam
Carepatron Exam 

Quality and best practices

  1. Make use of data annotation to apply basic validation.
  2. A well crafted application architecture must be considered to be able to support scalability and maintenability.
  3. Unit testing is a must to identify any issue at the earliest stage prior to development.
     
Can this submission's code architecture easily scale to a codebase with 20 developers?

At his stage not yet, but in order to do that, make use of the microservice arhictecture, by breaking the application into compnents and services to improved scalability and fault isolation.

How can you ensure data integrity in case of failures?

Data caching and mini data commit (per section of a larger data sets) to avoid lost of information.

How can you ensure the API behaves as you intend it to?

Test Driven Design (TDD) is one of the heavily used software devlopment practice, this will ensure that any changes will not introduce any issues. By applying this practices developers and testers can obtain optimzed codes that proves resilient in the long term.

How can you improve the performance of this?

To allow the application to support heavy request, break the application into services, this will allow all services to run on multiple host and capable of serving multiple request at the same time.


If time wasn't a constraint what else would you have done?
If time wasn't a constraint, I would have break each component into a service, to cater for future expansion (scope), maintenability and scalability.
    ClientRepository - into a seperate service (i.e. DataService)
    EmailRepository - service (i.e. EmailService)
    DocumentService - service (i.e. DocumentService)
    
How was this test overall? I.e too hard, too easy, how long it took, etc
The exam is a good code base line, it allows the developer to re-architecture the application and apply necessary best practices for future enhancements.
