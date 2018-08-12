﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	public Sprite dmgSprite;
	public int hp = 4;
	public AudioClip chopSound1;
	public AudioClip chopSound2;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Awake () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	public void DamageWall(int loss){
		spriteRenderer.sprite = dmgSprite;
		hp -= loss;
		if(hp<=0){
			gameObject.SetActive(false);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
