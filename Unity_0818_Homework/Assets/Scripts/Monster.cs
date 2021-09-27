using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 10)]
    public float move_speed = 3.5f;

    [Header("�����O"), Range(0, 500)]
    public float damage = 100f;

    [Header("��q"), Range(0, 5000)]
    public float monster_hp = 350f;

    [Header("�l�ܽd��"), Range(0, 50)]
    public float track_range = 30f;

    public Vector3 track_movement;

    [Header("�����D��")]
    public GameObject drop_item;

    [Header("�������v"), Range(0, 1)]
    public int drop_probability = 1;

    [Header("��������")]
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
