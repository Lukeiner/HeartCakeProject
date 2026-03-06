using UnityEngine;

namespace EvenTouch.Challenge.HeartCake
{
    public class CelebrationHandler : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private ParticleSystem confettiSystem;
        [SerializeField] private AudioSource celebrationSound;

        void Start()
        {
            if (confettiSystem != null)
            {
                confettiSystem.Stop(); // Nos aseguramos que empiece apagado por código
            }
        }
        public void LaunchCelebration()
        {
            if (confettiSystem != null)
            {
                // Detenemos por si el usuario lo apretó muy rápido antes
                confettiSystem.Stop();

                // ¡Disparamos!
                confettiSystem.Play();
                celebrationSound.Play();

            }
        }
    }
}
