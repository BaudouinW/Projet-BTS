<?php

/* SdzRentCarBundle:RentCarViews:ajouterVoiture.html.twig */
class __TwigTemplate_e9f7ff73ea4f39c658c113bc42da1ea7f58c92cc1caab8e08b19b7a2df91d9b9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = $this->env->loadTemplate("SdzRentCarBundle::layout.html.twig");

        $this->blocks = array(
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "SdzRentCarBundle::layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $this->parent->display($context, array_merge($this->blocks, $blocks));
    }

    // line 3
    public function block_body($context, array $blocks = array())
    {
        // line 4
        echo "
<h2>Ajouter une voiture</h2>
  ";
        // line 6
        $this->env->loadTemplate("SdzRentCarBundle:RentCarViews:formulaire.html.twig")->display($context);
        // line 7
        echo "  <p>
     Attention : cette voiture sera ajoutée directement
     sur la visionneuse après validation du formulaire.
  </p>
  
  <p>
      <a href=\"";
        // line 13
        echo $this->env->getExtension('routing')->getPath("sdzRentCarAppli_voir");
        echo "\" class=\"btn\">
      <i class=\"icon-chevron-left\"></i>
      << Retour à l'accueil
      </a>
  </p>
";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:ajouterVoiture.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  45 => 13,  37 => 7,  35 => 6,  31 => 4,  28 => 3,);
    }
}
