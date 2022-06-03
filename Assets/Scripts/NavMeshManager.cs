using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshManager : MonoBehaviour
{
    //Um array pegando os agentes
    GameObject[] agents;

    private void Start()
    {
        //Procurando os agentes pela tag do tipo ai
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    private void Update()
    {
        //Onde o mouse clicar
        if (Input.GetMouseButtonDown(0))
        {
            //Cria uma linha que bate com os componentes da cena
            RaycastHit hit;

            //F�sica que pega a posi��o que o mouse est� 
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 500))
            {
                foreach (GameObject a in agents)
                {
                    //Cria o destino em que o agente ir�
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }
            }
        }
    }
}
