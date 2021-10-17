
CREATE TABLE CreditCard
(
  CreditCardIssuerName VARCHAR(10) NOT NULL,
  CardHolderName VARCHAR(30) NOT NULL,
  ExpDate VARCHAR(5) NOT NULL,
  AddressLine1 VARCHAR(30) NOT NULL,
  AddressLine2 VARCHAR(15) NOT NULL,
  City VARCHAR(20) NOT NULL,
  State VARCHAR(20) NOT NULL,
  ZipCode VARCHAR(20) NOT NULL,
  CreditCardNumber VARCHAR(16) NOT NULL,
  PRIMARY KEY (CreditCardIssuerName, CreditCardNumber)
);

CREATE TABLE CustomerOrder
(
  PaymentMethod VARCHAR(10) NOT NULL,
  ID VARCHAR(21) NOT NULL,
  TotalCost VARCHAR(5) NOT NULL,
  Date VARCHAR(10) NOT NULL,
  PRIMARY KEY (ID)
);


CREATE TABLE Product
(
  Name VARCHAR(20) NOT NULL,
  IsLimited CHAR(1) NOT NULL,
  Category VARCHAR(10) NOT NULL,
  PRIMARY KEY (Name)
);

CREATE TABLE NonMember
(
  Name VARCHAR(30) NOT NULL,
  CustomerID VARCHAR(15) NOT NULL,
  PRIMARY KEY (CustomerID)
);

CREATE TABLE NonMemberCreditCard
(
  CustomerID VARCHAR(15) NOT NULL,
  CreditCardIssuerName VARCHAR(10) NOT NULL,
  CreditCardNumber VARCHAR(16) NOT NULL,
  PRIMARY KEY (CreditCardIssuerName, CreditCardNumber),
  FOREIGN KEY (CustomerID) REFERENCES NonMember(CustomerID) ON DELETE CASCADE,
  FOREIGN KEY (CreditCardIssuerName, CreditCardNumber) REFERENCES CreditCard(CreditCardIssuerName, CreditCardNumber) ON DELETE CASCADE
);

CREATE TABLE Member
(
  Name VARCHAR(30) NOT NULL,
  PhoneNumber VARCHAR(10) NOT NULL,
  Points VARCHAR(3) NOT NULL,
  PRIMARY KEY (PhoneNumber)
);

CREATE TABLE Order_Item
(
  Quantity INT NOT NULL,
  Name VARCHAR(20) NOT NULL,
  ID VARCHAR(21) NOT NULL,
  PRIMARY KEY (Name, ID),
  FOREIGN KEY (Name) REFERENCES Product(Name) ON DELETE CASCADE,
  FOREIGN KEY (ID) REFERENCES CustomerOrder(ID) ON DELETE CASCADE
);

CREATE TABLE MemberCreditCard
(
  CreditCardIssuerName VARCHAR(10) NOT NULL,
  CreditCardNumber VARCHAR(16) NOT NULL,
  PhoneNumber VARCHAR(10) NOT NULL,
  PRIMARY KEY (CreditCardIssuerName, CreditCardNumber),
  FOREIGN KEY (CreditCardIssuerName, CreditCardNumber) REFERENCES CreditCard(CreditCardIssuerName, CreditCardNumber) ON DELETE CASCADE,
  FOREIGN KEY (PhoneNumber) REFERENCES Member(PhoneNumber) ON DELETE CASCADE
);
