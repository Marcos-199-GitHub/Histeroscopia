using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes{

    public class UI : MonoBehaviour{
        public void exit(){
            Application.Quit();
        }

        public void cargarCaso( int caso ){
            SceneManager.LoadScene( caso );
        }
    }

}