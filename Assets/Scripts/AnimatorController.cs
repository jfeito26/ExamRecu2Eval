using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public enum PlayerState { IDLE, WALKING, JUMPING}
public class AnimatorController : MonoBehaviour
{
    private Animator _animator;
    private MarioScript _Marioscript;
    private SpriteRenderer _rend;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rend = GetComponent<SpriteRenderer>();
        _Marioscript = GetComponent<MarioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(_Marioscript.GetCurrentState())
        {
            case PlayerState.IDLE:
                _animator.SetBool("isWalking", false);
                    break;
            case PlayerState.WALKING:
                _animator.SetBool("isWalking", true);
                    break;
            case PlayerState.JUMPING:
                    break;
        }

        if(_Marioscript.GetDirection().x < 0)
        {
            _rend.flipX = true;
        }
        else if(_Marioscript.GetDirection().x  > 0)
        {
            _rend.flipX = false;
        }
    }
}
