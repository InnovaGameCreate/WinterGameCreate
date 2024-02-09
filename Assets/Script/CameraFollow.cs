using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // �v���C���[��Transform
    public Vector2 minPosition; // �J�����̈ړ��͈͂̍ŏ��l
    public Vector2 maxPosition; // �J�����̈ړ��͈͂̍ő�l

    void LateUpdate()
    {
            // �v���C���[�̈ʒu��ǐՁiz���͕ύX���Ȃ��j
            Vector3 targetPosition = new Vector3(
                Mathf.Clamp(player.position.x, minPosition.x, maxPosition.x),
                Mathf.Clamp(player.position.y, minPosition.y, maxPosition.y),
                transform.position.z
            );
            transform.position = targetPosition;
    }
}
