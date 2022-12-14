using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    public WeightedRandomList<Transform> lootTable;

    public Transform itemHolder;
    public GameObject SoundTest;
    Animator animator;
   

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (IsOpen())
            {
                animator.SetTrigger("close");
                HideItem();
                SceneManager.LoadScene(0);
            }
            else
            {
                animator.SetTrigger("open");
            }
        }
    }

    bool IsOpen()
    {
        return animator.GetCurrentAnimatorStateInfo(0).IsName("ChestOpen");
    }

    void HideItem()
    {
        itemHolder.localScale = Vector3.zero;
        itemHolder.gameObject.SetActive(false);

        foreach (Transform child in itemHolder)
        {
            Destroy(child.gameObject);
        }
    }

    void ShowItem()
    {
        Transform item = lootTable.GetRandom();
        Instantiate(item, itemHolder);
        itemHolder.gameObject.SetActive(true);
        Instantiate(SoundTest, transform.position, transform.rotation);        
    }
}
