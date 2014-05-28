<?php

/* SdzRentCarBundle:RentCarViews:louerVoiture.html.twig */
class __TwigTemplate_9a21c91c6bfa5d4a1cd45e69c3f139fd042738ba15ebf611a565eb24196098c9 extends Twig_Template
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
<h2>Emprunter un véhicule</h2>
  ";
        // line 6
        $this->env->loadTemplate("SdzRentCarBundle:RentCarViews:formulaireLouer.html.twig")->display($context);
        // line 7
        echo " 
  <p>
      <a href=\"";
        // line 9
        echo $this->env->getExtension('routing')->getPath("sdzRentCarAppli_voir");
        echo "\" class=\"btn\">
      <i class=\"icon-chevron-left\"></i>
      << Retour à la liste des véhicules
      </a>
  </p>
";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:louerVoiture.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  41 => 9,  37 => 7,  35 => 6,  31 => 4,  28 => 3,);
    }
}
