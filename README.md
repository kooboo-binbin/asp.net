Adyen ASP.NET Integration (C#)
==============
The code examples in this repository help you integrate with the Adyen platform using ASP.NET in C#. Please go through the code examples and read the documentation in the files itself. Each code example requires you to change some parameters to connect to your Adyen account, such as merchant account and skincode.

## Examples
```
1.HPP (Hosted Payment Page)
  - CreatePaymentOnHpp             : Simple form creating a payment on our HPP
  - CreatePaymentOnHppAdvanced     : Advanced form creating a payment on our HPP
  - CreatePaymentUrl               : Create payment URL on our HPP
2.API
  - HttpPost
    - CreatePaymentAPI             : Create a payment via our API using HTTP Post
    - CreatePaymentCSE             : Create a Client-Side Encrypted payment using HTTP Post
  - Soap
    - CreatePaymentAPI             : Create a payment via our API using SOAP
    - CreatePaymentCSE             : Create a Client-Side Encrypted payment using SOAP
3.Notifications
  - HttpPost
    - NotificationServer           : Receive our notifications using HTTP Post
4.Modifications
  - HttpPost
    - CancelOrRefundPayment        : Cancel or refund a payment using HTTP Post
    - CancelPayment                : Cancel a payment using HTTP Post
    - CapturePayment               : Capture a payment using HTTP Post
    - RefundPayment                : Request a refund using HTTP Post
  - Soap
    - CancelOrRefundPayment        : Cancel or refund a payment using SOAP
    - CancelPayment                : Cancel a payment using SOAP
    - CapturePayment               : Capture a payment using SOAP
    - RefundPayment                : Request a refund using SOAP
5.Recurring
  - HttpPost
    - CreateRecurringPayment       : Create a recurring payment using HTTP Post
    - DisableRecurringContract     : Disable a recurring contract using HTTP Post
    - RetrieveRecurringContract    : Retrieve a recurring contract using HTTP Post
  - Soap
    - CreateRecurringPayment       : Create a recurring payment using SOAP
    - DisableRecurringContract     : Disable a recurring contract using SOAP
    - RetrieveRecurringContract    : Retrieve a recurring contract using SOAP
6.PaymentMethods
  - GetPaymentMethods              : Get payment methods available for merchant account
7.OpenInvoice
  - HttpPost
    - OpenInvoiceServer            : Open invoice service using HTTP Post
8.CustomFields
  - HttpPost
    - CustomFieldsServer           : Custom fields service using HTTP Post
9.Payout
  - Soap
    - ConfirmPayoutRequest         : Confirm payout request using SOAP
    - DeclinePayoutRequest         : Decline payout request using SOAP
    - StorePayoutDetails           : Store payout details using SOAP
    - StorePayoutDetailsAndSubmit  : Store payout details and submit payout request using SOAP
    - SubmitPayoutRequest          : Submit payout request using SOAP
```

## Code structure
```
- 1.HPP, 2.API, 3.Notifications, ... : C# implementation of the examples
- App_WebReferences                  : Generated classes (Service References) for SOAP clients
- js
  - adyen.encrypt.min.js             : JavaScript file required for encrypting card data
- Web.config                         : Settings and configuration file for the ASP.NET application
```

## Manuals
The code examples are based on our Integration manual and the API manual which provides rich information on how our platform works. Please find our manuals on the Developers section at www.adyen.com.

## Support
If you do have any suggestions or questions regarding the code examples please send an e-mail to support@adyen.com.