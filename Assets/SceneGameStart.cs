using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGameStart : MonoBehaviour
{
    [SerializeField] GameObject ball;
    BallMove ballMove;
    Vector3 ballTransform;

    private void Start()
    {
        Cursor.visible = false;       
        ballTransform = ball.transform.position;
        ballMove = ball.GetComponent<BallMove>();
    }
    public IEnumerator StartScene(int dirX)
    {
        ballMove.Stop();
        ball.transform.position = ballTransform;
        yield return new WaitForSeconds(.5f);
        Debug.Log(new Vector3(dirX, 0, 0).normalized);
        ballMove.MyStart(new Vector3(dirX, 0f, 0f));
        yield break;
    }
}
