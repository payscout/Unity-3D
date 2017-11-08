using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CaptureSnippet : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(post());
    }

    IEnumerator post()
    {
        WWWForm form = new WWWForm();

        WWW request = new WWW("https://gatewaystaging.payscout.com/api/process", System.Text.Encoding.UTF8.GetBytes("client_username={yourUsername}&client_password={yourPassword}&client_token=token&processing_type=CAPTURE&currency=USD&initial_amount=99.99&original_transaction_id=A000133RY3R&billing_invoice_number=1999"));



        yield return request;

        if (request.error != null)
        {
            print("Error while sending the transaction: " + request.error);
        } else {
            print("Transaction successfully sent. Response: " + request.text);
        }
    }
}
 
