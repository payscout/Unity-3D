using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CreditSnippet : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(post());
    }

    IEnumerator post()
    {
        WWWForm form = new WWWForm();

        WWW request = new WWW("https://gatewaystaging.payscout.com/api/process", System.Text.Encoding.UTF8.GetBytes("client_username={yourUsername}&client_password={yourPassword}&client_token=token&processing_type=CREDIT&expiration_month=10&expiration_year=2022&account_number={yourTestCardNumber}&cvv2=123&currency=USD&initial_amount=99.99"));



        yield return request;

        if (request.error != null)
        {
            print("Error while sending the transaction: " + request.error);
        } else {
            print("Transaction successfully sent. Response: " + request.text);
        }
    }
}
 
