using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float move_speed = 3.5f;

    [Header("攻擊力"), Range(0, 500)]
    public float damage = 100f;

    [Header("血量"), Range(0, 5000)]
    public float monster_hp = 350f;

    [Header("追蹤範圍"), Range(0, 50)]
    public float track_range = 30f;

    public Vector3 track_movement;

    [Header("掉落道具")]
    public GameObject drop_item;

    [Header("掉落機率"), Range(0, 1)]
    public int drop_probability = 1;

    [Header("掉落音效")]
    public AudioClip drop_audio;

    public AudioClip hurt_audio;
    public AudioClip attack_audio;

    private AudioSource aSource;
    private Rigidbody2D rigid;
    private Animation cus_animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
