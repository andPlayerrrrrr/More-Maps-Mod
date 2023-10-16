using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 initialPosition;
    public float timeX = 1.0f;
    public float timeY = 0f;
    private List<GameObject> ride = new List<GameObject>(); //���ɏ���Ă�I�u�W�F�N�g
    public void Start()
    {
            initialPosition = transform.position;
    }
    public void FixedUpdate()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time) * timeX + initialPosition.x, Mathf.Sin(Time.time) * timeY + initialPosition.y);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
        }
    }
    /// <summary>
    /// �ړ����̃R���C�_�[��obj���痣�ꂽ���̏���
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // �G�ꂽobj�̐e���Ȃ���
            other.transform.SetParent(null);
        }
    }
}
