using System;
using UnityEngine;

public class MonoComponent : MonoBehaviour
{

    // -----------------------------------------------------------
    // Métodos de Inicialización
    // -----------------------------------------------------------

    /// <summary>
    /// Se llama una vez cuando el script se carga. Es el primer método que se ejecuta, incluso antes que Awake.
    /// Se usa principalmente para inicializar variables, pero no para interactuar con otros GameObjects.
    /// </summary>
    public virtual void OnAwake()
    {
    }
    protected virtual void Awake()
    {
    }

    /// <summary>
    /// Se llama una vez cuando el GameObject está activado. Es útil para lógica que necesita ejecutarse
    /// cada vez que el GameObject se activa, no solo al inicio.
    /// </summary>
    public virtual void Enable()
    {
    }
    protected virtual void OnEnable()
    {
    }

    // -----------------------------------------------------------
    // Métodos de Actualización
    // -----------------------------------------------------------

    public event Action<GameObject> OnObjectDetected;

    protected virtual Action<GameObject> OnDetected => null;

    protected virtual bool AutoSubscribe => true;
    public virtual void OnStart()
    {
        if (OnDetected != null)
            if (AutoSubscribe)
                OnObjectDetected += OnDetected;
    }
    /// <summary>
    /// Se llama una vez después de Awake. Es ideal para inicializar referencias a otros componentes o GameObjects,
    /// ya que para este momento, todos los GameObjects y sus scripts ya han ejecutado su Awake.
    /// </summary>
    protected virtual void Start()
    {
        OnStart();
    }

    /// <summary>
    /// Se llama en cada fotograma. Es el lugar principal para la lógica del juego, como movimiento de personajes,
    /// detección de entrada del usuario o actualizaciones de estado.
    /// </summary>
    public virtual void OnUpdate()
    {
    }
    protected virtual void Update()
    {
        OnUpdate();
    }

    /// <summary>
    /// Se llama en cada fotograma después de que se ha ejecutado todo el código en Update. Es útil
    /// para la lógica que debe ocurrir después de que se han completado todas las actualizaciones de posición,
    /// como la lógica de cámaras o de seguimiento.
    /// </summary>
    public virtual void OnLateUpdate()
    {
    }
    protected virtual void LateUpdate()
    {
    }

    /// <summary>
    /// Se llama en un intervalo de tiempo fijo, independientemente de los fotogramas. Se usa para
    /// física (Physics), como la manipulación de Rigidbodies.
    /// </summary>
    public virtual void OnFixedUpdate()
    {
    }
    protected virtual void FixedUpdate()
    {
        OnFixedUpdate();
    }

    // -----------------------------------------------------------
    // Métodos de Detección de Colisiones
    // -----------------------------------------------------------

    /// <summary>
    /// Se llama en el primer fotograma en que el Collider del GameObject entra en contacto con otro Collider.
    /// </summary>
    /// <param name="collision">Información de la colisión.</param>
    public virtual void CollisionEnter(Collision collision)
    {
    }
    protected virtual void OnCollisionEnter(Collision collision)
    {
    }

    /// <summary>
    /// Se llama en cada fotograma en que el Collider del GameObject está en contacto con otro Collider.
    /// </summary>
    /// <param name="collision">Información de la colisión.</param>
    public virtual void CollisionStay(Collision collision)
    {
    }
    protected virtual void OnCollisionStay(Collision collision)
    {
    }

    /// <summary>
    /// Se llama en el último fotograma en que el Collider del GameObject estaba en contacto con otro Collider.
    /// </summary>
    /// <param name="collision">Información de la colisión.</param>
    public virtual void CollisionExit(Collision collision)
    {
    }
    protected virtual void OnCollisionExit(Collision collision)
    {
    }

    // -----------------------------------------------------------
    // Métodos de Destrucción y Desactivación
    // -----------------------------------------------------------

    /// <summary>
    /// Se llama cuando el GameObject se desactiva. Es el opuesto de OnEnable.
    /// </summary>
    public virtual void Disable()
    {
    }
    protected virtual void OnDisable()
    {
    }

    public virtual void Destroy()
    {
        if (OnDetected != null)
            OnObjectDetected -= OnDetected;
    }
    /// <summary>
    /// Se llama cuando el script o GameObject se destruye. Es útil para limpiar recursos, como
    /// desuscribirse de eventos.
    /// </summary>
    protected virtual void OnDestroy()
    {
        Destroy();
    }

    public virtual void CollisionEnter2D(Collision2D collision)
    {
        OnObjectDetected?.Invoke(collision.gameObject);
    }
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        CollisionEnter2D(collision);
    }

    public virtual void TriggerEnter2D(Collider2D other)
    {
        OnObjectDetected?.Invoke(other.gameObject);
    }
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        TriggerEnter2D(other);
    }

    public virtual void CollisionExit2D(Collision2D collision)
    {
    }
    protected virtual void OnCollisionExit2D(Collision2D collision)
    {
    }

    public virtual void TriggerEnter(Collider other)
    {
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
    }

    public virtual void TriggerStay(Collider other)
    {
    }
    protected virtual void OnTriggerStay(Collider other)
    {
    }

    public virtual void TriggerExit(Collider other)
    {
    }
    protected virtual void OnTriggerExit(Collider other)
    {
    }

}