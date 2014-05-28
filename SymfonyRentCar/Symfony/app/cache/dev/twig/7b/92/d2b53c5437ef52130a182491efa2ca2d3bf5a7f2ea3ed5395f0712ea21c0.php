<?php

/* SdzRentCarBundle:RentCarViews:listeLouer.html.twig */
class __TwigTemplate_7b92d2b53c5437ef52130a182491efa2ca2d3bf5a7f2ea3ed5395f0712ea21c0 extends Twig_Template
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
        echo "  Liste des véhicules louée - ";
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
      Liste des véhicules louée
    </h1></strong>
      
<div class=\"well\">
    <ul>
        ";
        // line 16
        $context['_parent'] = (array) $context;
        $context['_seq'] = twig_ensure_traversable((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")));
        foreach ($context['_seq'] as $context["_key"] => $context["voitureLouer"]) {
            // line 17
            echo "          <li><strong>Véhicule louée</strong>: ";
            echo twig_escape_filter($this->env, $this->getAttribute($this->getAttribute((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")), "voiture"), "getVoitureNom", array(), "method"), "html", null, true);
            echo "<br/>
              <strong>Nom de l'employé</strong>: ";
            // line 18
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")), "nomEmploye"), "html", null, true);
            echo "<br/>
              <strong>Adresse email</strong>: ";
            // line 19
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")), "email"), "html", null, true);
            echo "<br/>
              <strong>Service</strong>: ";
            // line 20
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")), "service"), "html", null, true);
            echo "</br>
              <strong>Raison de l'emprunt</strong>: ";
            // line 21
            echo twig_escape_filter($this->env, $this->getAttribute((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")), "raisonEmprunt"), "html", null, true);
            echo "</br>
              <strong>Date de début de location</strong>: ";
            // line 22
            echo twig_escape_filter($this->env, twig_date_format_filter($this->env, $this->getAttribute((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")), "dateDebut"), "d/m/Y"), "html", null, true);
            echo "</br>
              <strong>Date de fin de location</strong>: ";
            // line 23
            echo twig_escape_filter($this->env, twig_date_format_filter($this->env, $this->getAttribute((isset($context["voitureLouer"]) ? $context["voitureLouer"] : $this->getContext($context, "voitureLouer")), "dateFin"), "d/m/Y"), "html", null, true);
            echo "</br>
              ";
            // line 25
            echo "              </li>
        ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['voitureLouer'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 27
        echo "      </ul>
    
  </div>

";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:listeLouer.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  91 => 27,  84 => 25,  80 => 23,  76 => 22,  72 => 21,  68 => 20,  64 => 19,  60 => 18,  55 => 17,  51 => 16,  42 => 9,  39 => 8,  32 => 5,  29 => 4,);
    }
}
