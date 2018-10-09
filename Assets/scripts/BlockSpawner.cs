
using UnityEngine;

public class BlockSpawner : BlockRemover {
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public GameObject life;
    // Use this for initialization
    private float timeToSpawn = 2f;
    public bool spawnato = false;
    public float timeBetweenWaves = 1f;
    public int nBlocchi = 1;
	
	// Update is called once per frame

	void Update () {

        if ((int)points < 1)
            nBlocchi = 1;
        else if ((int)points < 3)
            nBlocchi = 2;
        else if ((int)points < 10)
            nBlocchi = 3;
        else if ((int)points < 15)
            nBlocchi = 4;
        else if ((int)points < 25)
            nBlocchi = 5;
        else
            nBlocchi = 6;

        if ((int)points>15 && !spawnato)
        {
            spawnato = true;
            spawnLives();
        }
        else if (Time.time >= timeToSpawn)
        {
            spawnato = false;
            spawnBlocks(nBlocchi);
                timeToSpawn = Time.time + timeBetweenWaves;

        }
    }

    bool inIT(int random, int nBlocchi, int[] vettore){
        bool preson = false;
        for (int i = 0; i < nBlocchi; i++){
            if (random != vettore[i])
                preson = true;
            return preson;
        }
        return preson;
    }
    void spawnBlocks(int nBlocchi){
        int randomIndex = Random.Range(0, spawnPoints.Length);

        
        for (int i = 0; i < spawnPoints.Length; i++){
            if (nBlocchi == 1)
            {
                if (randomIndex == i)
                    Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
            else 
            {
               for (int v = 0; v < nBlocchi; v++)
                {
                    int[] preso = new int[10];
                    randomIndex = Random.Range(0, spawnPoints.Length);
                    preso[0] = 8;
                    if (randomIndex == i && inIT(randomIndex,nBlocchi,preso))
                    {
                        preso[v] = randomIndex;
                        Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
                    }

                }
                    
            }
        }
    }

    void spawnLives(){
           int x = Random.Range(0, spawnPoints.Length);
           Instantiate(life, spawnPoints[x].position, Quaternion.identity);
    }
    /*
    void ricarica(){
        int x = Random.Range(0, spawnPoints.Length);
        if (randomIndex == i && inIT(randomIndex, nBlocchi, preso))

            if (randomIndex == i && !inIT(randomIndex, nBlocchi, preso)

        if (randomIndex == i && !inIT(randomIndex, nBlocchi, preso))
        {
            preso[v] = randomIndex;
            Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
        }
       


    }*/
}

