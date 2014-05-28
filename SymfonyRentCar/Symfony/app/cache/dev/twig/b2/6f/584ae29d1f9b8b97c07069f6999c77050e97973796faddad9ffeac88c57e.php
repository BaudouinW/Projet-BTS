<?php

/* SdzRentCarBundle:RentCarViews:listeDispo.html.twig */
class __TwigTemplate_b26f584ae29d1f9b8b97c07069f6999c77050e97973796faddad9ffeac88c57e extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = $this->env->loadTemplate("SdzRentCarBundle::layout.html.twig");

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'RentCarAppli_body' => array($this, 'block_RentCarAppli_body'),
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

    // line 4
    public function block_title($context, array $blocks = array())
    {
        // line 5
        echo "  Liste - ";
        $this->displayParentBlock("title", $context, $blocks);
        echo "
";
    }

    // line 8
    public function block_RentCarAppli_body($context, array $blocks = array())
    {
        // line 9
        echo "  
  <strong> <h1 style=\"font-size: 24px;\">
     Véhicules disponible
    </h1></strong>
 
      
<div class=\"well\">
       <ul>
        ";
        // line 17
        $context['_parent'] = (array) $context;
        $context['_seq'] = twig_ensure_traversable((isset($context["voiture"]) ? $context["voiture"] : $this->getContext($context, "voiture")));
        foreach ($context['_seq'] as $context["_key"] => $context["voiture"]) {
            // line 18
            echo "          <li><strong>Nom</strong>: ";
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voiture"]) ? $context["voiture"] : $this->getContext($context, "voiture")), "voitureNom"), "html", null, true);
            echo "<br/>
              <strong>Marque</strong>: ";
            // line 19
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voiture"]) ? $context["voiture"] : $this->getContext($context, "voiture")), "marque"), "html", null, true);
            echo "<br/>
              <strong>Boîte de Vitesse</strong>: ";
            // line 20
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voiture"]) ? $context["voiture"] : $this->getContext($context, "voiture")), "boiteVitesse"), "html", null, true);
            echo "<br/>
              <strong>Carburant</strong>: ";
            // line 21
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voiture"]) ? $context["voiture"] : $this->getContext($context, "voiture")), "typeEssence"), "html", null, true);
            echo "<br/>
              <strong>Nombre de kilomètre</strong>: ";
            // line 22
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voiture"]) ? $context["voiture"] : $this->getContext($context, "voiture")), "nombreKilometre"), "html", null, true);
            echo "</br>
              <strong>Description</strong>: ";
            // line 23
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voiture"]) ? $context["voiture"] : $this->getContext($context, "voiture")), "description"), "html", null, true);
            echo "<br/>
          </li></br>
        ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['voiture'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 26
        echo "      </ul>
    
  </div>

";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:listeDispo.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  86 => 26,  77 => 23,  73 => 22,  69 => 21,  65 => 20,  61 => 19,  56 => 18,  52 => 17,  42 => 9,  39 => 8,  32 => 5,  29 => 4,);
    }
}
