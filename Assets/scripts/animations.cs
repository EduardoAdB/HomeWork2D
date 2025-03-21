using System.Collections;
using UnityEngine;

public class animations : MonoBehaviour
{
    public Animator Warrior;
    public AudioSource Atack;
    public AudioSource Jump;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Warrior.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Warrior.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Warrior.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Warrior.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Warrior.SetBool("Jump", true);
            Jump.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Warrior.SetBool("Jump", false);
            Warrior.SetBool("Fall", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Warrior.SetBool("Fall", false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Warrior.SetBool("LAtack", true);
            Atack.Play();
            StartCoroutine(ResetLAtack());
        }
    }

    private IEnumerator ResetLAtack()
    {
        // Obtém a duração da animação "LAtack"
        AnimatorStateInfo stateInfo = Warrior.GetCurrentAnimatorStateInfo(0);
        float animationDuration = stateInfo.length;

        // Aguarda o tempo da animação
        yield return new WaitForSeconds(animationDuration);

        // Reseta o booleano
        Warrior.SetBool("LAtack", false);
    }

}