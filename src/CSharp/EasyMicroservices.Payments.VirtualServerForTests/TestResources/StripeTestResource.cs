using System.Collections.Generic;

namespace EasyMicroservices.Payments.VirtualServerForTests.TestResources
{
    public static class StripeTestResource
    {
        public static Dictionary<string, string> GetResources()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add($@"POST /v1/products HTTP/1.1
*RequestSkipBody*",

$@"HTTP/1.1 200 OK
Server: nginx
Date: Mon, 02 Oct 2023 10:44:17 GMT
Content-Type: application/json
Connection: keep-alive
Access-Control-Allow-Credentials: true
Access-Control-Allow-Methods: GET,HEAD,PUT,PATCH,POST,DELETE
Access-Control-Allow-Origin: *
Access-Control-Expose-Headers: Request-Id, Stripe-Manage-Version, X-Stripe-External-Auth-Required, X-Stripe-Privileged-Session-Required
Access-Control-Max-Age: 300
Cache-Control: no-cache, no-store
Content-Security-Policy: report-uri /csp-report?p=%2Fv1%2Fproducts;block-all-mixed-content;default-src 'none' 'report-sample';base-uri 'none';form-action 'none';style-src 'unsafe-inline';frame-ancestors 'self';connect-src 'self';img-src 'self' https://b.stripecdn.com
Content-Security-Policy-Report-Only: report-uri /csp-report?p=v1%2Fproducts; block-all-mixed-content; default-src 'none'; base-uri 'none'; form-action 'none'; frame-ancestors 'none'; img-src 'self'; script-src 'self' 'report-sample'; style-src 'self'
Expires: 0
Idempotency-Key: 8d546b52-0212-443b-955d-f0e480d00778
Original-Request: req_vxpJMdF6rbceJq
Pragma: no-cache
Referrer-Policy: strict-origin-when-cross-origin
Request-Id: req_vxpJMdF6rbceJq
Stripe-Should-Retry: false
Stripe-Version: 2023-08-16
Vary: Origin
X-Stripe-Routing-Context-Priority-Tier: api-testmode
Strict-Transport-Security: max-age=63072000; includeSubDomains; preload
Content-Length: 0

            {{""id"":""prod_OkDGJYSWbbrByC"",""object"":""product"",""active"":true,""created"":1696240502,""default_price"":""price_1NsdvsdveweT6kDcHTUC"",""description"":null,""features"":[],""images"":[],""livemode"":false,""metadata"":{{}},""name"":""Test"",""package_dimensions"":null,""shippable"":null,""statement_descriptor"":null,""tax_code"":null,""type"":""service"",""unit_label"":null,""updated"":1696240502,""url"":null}}");

            result.Add($@"POST /v1/prices HTTP/1.1
*RequestSkipBody*",

$@"HTTP/1.1 200 OK
Server: nginx
Date: Mon, 02 Oct 2023 10:44:17 GMT
Content-Type: application/json
Connection: keep-alive
Access-Control-Allow-Credentials: true
Access-Control-Allow-Methods: GET,HEAD,PUT,PATCH,POST,DELETE
Access-Control-Allow-Origin: *
Access-Control-Expose-Headers: Request-Id, Stripe-Manage-Version, X-Stripe-External-Auth-Required, X-Stripe-Privileged-Session-Required
Access-Control-Max-Age: 300
Cache-Control: no-cache, no-store
Content-Security-Policy: report-uri /csp-report?p=%2Fv1%2Fproducts;block-all-mixed-content;default-src 'none' 'report-sample';base-uri 'none';form-action 'none';style-src 'unsafe-inline';frame-ancestors 'self';connect-src 'self';img-src 'self' https://b.stripecdn.com
Content-Security-Policy-Report-Only: report-uri /csp-report?p=v1%2Fproducts; block-all-mixed-content; default-src 'none'; base-uri 'none'; form-action 'none'; frame-ancestors 'none'; img-src 'self'; script-src 'self' 'report-sample'; style-src 'self'
Expires: 0
Idempotency-Key: 8d546b52-0212-443b-955d-f0e480d00778
Original-Request: req_vxpJMdF6rbceJq
Pragma: no-cache
Referrer-Policy: strict-origin-when-cross-origin
Request-Id: req_vxpJMdF6rbceJq
Stripe-Should-Retry: false
Stripe-Version: 2023-08-16
Vary: Origin
X-Stripe-Routing-Context-Priority-Tier: api-testmode
Strict-Transport-Security: max-age=63072000; includeSubDomains; preload
Content-Length: 0

            {{""id"":""price_1NwiqEDK72gdvsvT23TSTFlB"",""object"":""price"",""active"":true,""billing_scheme"":""per_unit"",""created"":1696240506,""currency"":""usd"",""currency_options"":null,""custom_unit_amount"":null,""livemode"":false,""lookup_key"":null,""metadata"":{{}},""nickname"":null,""product"":""prod_OkDGJYSWbbrByC"",""recurring"":null,""tax_behavior"":""unspecified"",""tiers"":null,""tiers_mode"":null,""transform_quantity"":null,""type"":""one_time"",""unit_amount"":1000,""unit_amount_decimal"":1000.0}}");

            result.Add($@"POST /v1/checkout/sessions HTTP/1.1
*RequestSkipBody*",

$@"HTTP/1.1 200 OK
Server: nginx
Date: Mon, 02 Oct 2023 10:44:17 GMT
Content-Type: application/json
Connection: keep-alive
Access-Control-Allow-Credentials: true
Access-Control-Allow-Methods: GET,HEAD,PUT,PATCH,POST,DELETE
Access-Control-Allow-Origin: *
Access-Control-Expose-Headers: Request-Id, Stripe-Manage-Version, X-Stripe-External-Auth-Required, X-Stripe-Privileged-Session-Required
Access-Control-Max-Age: 300
Cache-Control: no-cache, no-store
Content-Security-Policy: report-uri /csp-report?p=%2Fv1%2Fproducts;block-all-mixed-content;default-src 'none' 'report-sample';base-uri 'none';form-action 'none';style-src 'unsafe-inline';frame-ancestors 'self';connect-src 'self';img-src 'self' https://b.stripecdn.com
Content-Security-Policy-Report-Only: report-uri /csp-report?p=v1%2Fproducts; block-all-mixed-content; default-src 'none'; base-uri 'none'; form-action 'none'; frame-ancestors 'none'; img-src 'self'; script-src 'self' 'report-sample'; style-src 'self'
Expires: 0
Idempotency-Key: 8d546b52-0212-443b-955d-f0e480d00778
Original-Request: req_vxpJMdF6rbceJq
Pragma: no-cache
Referrer-Policy: strict-origin-when-cross-origin
Request-Id: req_vxpJMdF6rbceJq
Stripe-Should-Retry: false
Stripe-Version: 2023-08-16
Vary: Origin
X-Stripe-Routing-Context-Priority-Tier: api-testmode
Strict-Transport-Security: max-age=63072000; includeSubDomains; preload
Content-Length: 0

            {{""id"":""cs_test_a1qlnJteMKipT19Jawvbnngbdfcdsj832YeARo1DAJjdPgNWYeHaP"",""object"":""checkout.session"",""after_expiration"":null,""allow_promotion_codes"":null,""amount_subtotal"":1000,""amount_total"":1000,""automatic_tax"":{{""enabled"":false,""status"":null}},""billing_address_collection"":null,""cancel_url"":null,""client_reference_id"":null,""consent"":null,""consent_collection"":null,""created"":1696240507,""currency"":""usd"",""currency_conversion"":null,""custom_fields"":[],""custom_text"":{{""shipping_address"":null,""submit"":null,""terms_of_service_acceptance"":null}},""customer"":null,""customer_creation"":""if_required"",""customer_details"":null,""customer_email"":null,""expires_at"":1696326907,""invoice"":null,""invoice_creation"":{{""enabled"":false,""invoice_data"":{{""account_tax_ids"":null,""custom_fields"":null,""description"":null,""footer"":null,""metadata"":{{}},""rendering_options"":null}}}},""line_items"":null,""livemode"":false,""locale"":null,""metadata"":{{}},""mode"":""payment"",""payment_intent"":null,""payment_link"":null,""payment_method_collection"":""if_required"",""payment_method_configuration_details"":null,""payment_method_options"":{{""acss_debit"":null,""affirm"":null,""afterpay_clearpay"":null,""alipay"":null,""au_becs_debit"":null,""bacs_debit"":null,""bancontact"":null,""boleto"":null,""card"":null,""cashapp"":null,""customer_balance"":null,""eps"":null,""fpx"":null,""giropay"":null,""grabpay"":null,""ideal"":null,""klarna"":null,""konbini"":null,""link"":null,""oxxo"":null,""p24"":null,""paynow"":null,""pix"":null,""sepa_debit"":null,""sofort"":null,""us_bank_account"":null}},""payment_method_types"":[""card""],""payment_status"":""unpaid"",""phone_number_collection"":{{""enabled"":false}},""recovered_from"":null,""setup_intent"":null,""shipping_address_collection"":null,""shipping_cost"":null,""shipping_details"":null,""shipping_options"":[],""status"":""open"",""submit_type"":null,""subscription"":null,""success_url"":""http://localhost:1061/successurl"",""tax_id_collection"":null,""total_details"":{{""amount_discount"":0,""amount_shipping"":0,""amount_tax"":0,""breakdown"":null}},""url"":""https://checkout.stripe.com/c/pay/cs_test_a1qlnJteMKipT19JawGXblOfUrPJz8VKdsj832YeARo1DAJjdPgNWYeHaP#fidkdWxOYHwnPyd1blpxYHZxWjA0S3dwR2lBTjI3YlVgcmBRVkl2Q25NN2hkYFJRMjVybzJJN0NWaGNQaGNha09Ka3RBak9cMmxzST1fdm9xaVFcbmhSf1JLYEc9bHdtNzRWZ3JmUHNGPHBpNTVxTmCFMlBSUScpJ2N3amhWYHdzYHcnfvbdlkfGpwcVF8dWAnPyd2bGtiaWBabHFgaCcpJ2BrZGdpYFVpZGZgbWppYWB3dic%2FcXdwYHgl""}}");
            return result;
        }
    }
}
