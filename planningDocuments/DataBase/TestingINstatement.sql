ZA

insert into CreditCard(CreditCardIssuerName, CreditCardNumber,
CardHolderName, ExpDate, AddressLine1,AddressLine2,City,State,
ZipCode)
Values("Visa" ,"2", 'Horacio','03/21','benham st','none', 
'Elmhurst', 'NY','11373');

Insert into MemberCreditCard (CreditCardNumber, CreditCardIssuerName,
PhoneNumber)
Values("2","Visa", "3479955274");

Insert into MemberCreditCard (CreditCardNumber, CreditCardIssuerName,
PhoneNumber)
Values("11","MasterCard", "3479955274");

Insert into Member(PhoneNumber,Name,Points)
Values('3479955274','Horacio', '0');

Insert into Member(PhoneNumber,Name,Points)
Values('3475105469','Julia', '0');

SELECT CreditCardIssuerName, CardHolderName,ExpDate, 
CreditCardNumber FROM CreditCard WHERE CreditCardNumber IN 
(SELECT CreditCardNumber FROM MemberCreditCard
 WHERE PhoneNumber ='3479955274');
 
 
insert into CreditCard(CreditCardIssuerName, CreditCardNumber,
CardHolderName, ExpDate, AddressLine1,AddressLine2,City,State,
ZipCode)
Values("Visa" ,"12", 'Horacio','03/21','benham st','none', 
'Elmhurst', 'NY','11373');

insert into CreditCard(CreditCardIssuerName, CreditCardNumber,
CardHolderName, ExpDate, AddressLine1,AddressLine2,City,State,
ZipCode)
Values("MasterCard" ,"2", 'Julia','03/21','benham st','none', 
'Elmhurst', 'NY','11373');

 select * from Member;
 select * from CreditCard;
 select * from MemberCreditCard;
 DELETE FROM CreditCard WHERE CreditCardIssuerName="MasterCard";