using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SonucManager : MonoBehaviour
{

    [SerializeField]
    private Text dogruText, yanlisText, puanText;

    [SerializeField]
    private GameObject birinciYildiz,ikinciYildiz,ucuncuYildiz;



    public void SonuclariYazdir(int dogruAdet, int yanlisAdet, int puan)
    {
        dogruText.text = dogruAdet.ToString();
        yanlisText.text = yanlisAdet.ToString();
        puanText.text = puan.ToString();

        birinciYildiz.SetActive(false);
        ikinciYildiz.SetActive(false);
        ucuncuYildiz.SetActive(false);

        if(dogruAdet == 1)
        {
            birinciYildiz.SetActive(true);
        }else if(dogruAdet == 2){
            birinciYildiz.SetActive(true);
            ikinciYildiz.SetActive(true);
        }else
        {
            birinciYildiz.SetActive(true);
            ikinciYildiz.SetActive(true);
            ucuncuYildiz.SetActive(true);
        }
    }

    public void GeriDonButton(){
        SceneManager.LoadScene("SampleScene");
    }
}
