"# validate-ardwin-tests" 


All application you can use swagger , after run the app ,accessing link :

https://localhost:5001/swagger/index.html

I choosed use swagger due interface already prepared to get all information that we need to use the APi's.

Requirements: 

1 – API that receive customer card and save it 

Request information: 
CustomerId - int 
Card Number – long - max 16 characters 
CVV – int - max 5 characters 

Ex. 

{

  "customerId": 500,
  "cardNumber": 4532000122534569,
  "cvv": 12345
 
}

 
Response information:  
creation date – Date now in UTC  
Token – Guid  
CardId - Guid 
 


2 – API that validate that token

endpoint: https://localhost:5001/api/validate

Ex.

{
  
  "customerId": 500,
  "cardNumber": 4532000122534569,
  "cvv": 12345,
  "cardId": "ebac6032-d35e-4b2a-ac91-bfc7779284d3",
  "token": "700f5711-59c6-43c9-9cf4-9817ce47453a",
 
}


3- Rotate

endpoint: https://localhost:5001/api/rotate


Here , i preferred still using this solution for answer this question and i put hard code just for testing an array.
To change just open method and change numbers in array to check the rotatation works!

PS:
There are some stuffs that would like to implement such as custom annotation that we be possible to read from source a string with min and max length [16] in Card Number field
after parsing to long, but there are other option that can be best explored in front-end.








