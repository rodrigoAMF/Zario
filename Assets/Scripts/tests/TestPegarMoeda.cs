using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestPegarMoeda {

    [Test]
    public void TestPegarMoedaSimplePasses() {
        PlayerController playerController = new PlayerController();

        int numeroMoedas = playerController.getNumeroMoedas();

        playerController.setNumeroMoedas(playerController.getNumeroMoedas() + 1);
        Assert.AreEqual(playerController.getNumeroMoedas(), numeroMoedas + 1);
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TestPegarMoedaWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
