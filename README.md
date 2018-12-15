# SMTP Configuration Tester
Tools for check smtp client configuration
## Configuration
Open file `SMTPTester.FullFx.exe.config`
Change value based on your configuration

```xml
 <smtp deliveryMethod="Network" from="***">
    <network host="***" userName="***" password="***" port="25" enableSsl="false" />
</smtp>
```