# DIO Microsoft Azure Essentials - Resumão do Curso

## O Que é o Azure

O Azure é uma plataforma de computação em nuvem da Microsoft que oferece uma variedade de serviços, incluindo computação, armazenamento, análise e redes. Ele permite que empresas e desenvolvedores criem, implantem e gerenciem aplicativos e serviços por meio de datacenters globais. A flexibilidade e a escalabilidade do Azure fazem dele uma escolha popular para soluções em nuvem, atendendo tanto pequenas empresas quanto grandes corporações.

## Criando uma Conta no Azure

Para começar a usar o Azure, é necessário criar uma conta. O processo é simples e envolve as seguintes etapas:

1. **Visitar o site do Azure**: Acesse a página oficial do Azure.
2. **Selecionar "Começar gratuitamente"**: Isso oferece um período de teste e créditos iniciais.
3. **Criar um perfil**: Insira informações pessoais, como nome, e-mail e detalhes de pagamento (opcional durante o teste).
4. **Verificar a conta**: Siga as instruções para validar seu e-mail e, se necessário, seu número de telefone.
5. **Explorar o portal**: Após a criação da conta, você pode acessar o portal do Azure para gerenciar serviços.

## O Portal do Azure

O portal do Azure é uma interface baseada na web que permite aos usuários gerenciar recursos e serviços na plataforma. Através dele, é possível:

- **Criar e gerenciar recursos**: Criação de máquinas virtuais, bancos de dados, aplicativos e muito mais.
- **Monitorar serviços**: Visualizar desempenho, uso e métricas dos recursos implantados.
- **Configurar segurança e governança**: Gerenciar permissões e políticas de acesso.
- **Acessar documentação e suporte**: Encontrar guias, tutoriais e recursos de ajuda.

O portal é projetado para ser intuitivo, permitindo que usuários de todos os níveis de experiência naveguem e utilizem suas funcionalidades de forma eficiente.

## Benefícios da Nuvem

A computação em nuvem oferece diversos benefícios que ajudam empresas a otimizar seus recursos e operações. Alguns dos principais benefícios incluem:

- **Escalabilidade**: Permite ajustar rapidamente a capacidade dos recursos de acordo com a demanda, garantindo que os serviços possam crescer ou diminuir conforme necessário.
- **Elasticidade**: Os recursos podem ser provisionados e liberados automaticamente, permitindo que as empresas paguem apenas pelo que realmente utilizam.
- **Confiabilidade**: A infraestrutura de nuvem é projetada para garantir alta disponibilidade e continuidade de negócios, minimizando o risco de falhas.
- **Previsibilidade**: Com ferramentas de monitoramento e análise, as empresas podem prever tendências de uso e planejar melhor seus recursos.
- **Segurança**: Fornece diversas camadas de segurança, incluindo criptografia, autenticação e controle de acesso, para proteger dados e aplicações.
- **Governança**: Permite que as organizações implementem políticas e controles para garantir a conformidade e a gestão eficaz dos recursos.
- **Gerenciabilidade**: Facilita o gerenciamento centralizado dos recursos, simplificando tarefas de administração e manutenção.

## Service Level Agreement

Um Service Level Agreement (SLA) é um contrato que define os níveis de serviço esperados entre um provedor de serviços em nuvem e um cliente. Ele especifica as métricas de desempenho, como disponibilidade e tempo de resposta. No Azure, os SLAs geralmente oferecem percentuais de disponibilidade que variam de 99,9% a 99,99999%, dependendo do serviço. Isso garante que os clientes tenham uma expectativa clara sobre a confiabilidade dos serviços que estão utilizando.

## Como Criar uma Máquina Virtual

Criar uma máquina virtual no Azure é um processo simples e envolve algumas etapas principais. As opções disponíveis incluem:

1. **Escolher o sistema operacional**: Você pode optar por diversas distribuições do Windows e Linux.
2. **Selecionar a configuração da VM**: Escolha entre diferentes tamanhos e tipos de máquina, dependendo da carga de trabalho (ex: General Purpose, Compute Optimized).
3. **Configurar armazenamento**: Escolha entre discos gerenciados ou não gerenciados, além de definir o tipo de armazenamento (SSD, HDD).
4. **Definir rede**: Configure as definições de rede, incluindo segurança, grupos de segurança e sub-redes.
5. **Configurações adicionais**: Defina opções como autenticação, backup e monitoramento.

Após a configuração, você pode iniciar a máquina virtual e gerenciá-la através do portal do Azure ou por meio de scripts automáticos.

## Tipos de Serviço de Nuvem na Azure

A Azure oferece três principais modelos de serviços em nuvem:

- **IaaS (Infrastructure as a Service)**: Proporciona infraestrutura básica, como máquinas virtuais e redes. Exemplos incluem Azure Virtual Machines e Azure Virtual Networks.
- **PaaS (Platform as a Service)**: Fornece uma plataforma completa para desenvolvimento, teste e implementação de aplicações, sem se preocupar com a infraestrutura subjacente. Exemplos incluem Azure App Service e Azure Functions.
- **SaaS (Software as a Service)**: Oferece aplicativos prontos para uso, acessíveis via internet, como Microsoft 365 e Dynamics 365.

Esses modelos permitem que as empresas escolham o nível de controle e responsabilidade que desejam ter sobre seus recursos em nuvem.

## Modelo de Responsabilidade Compartilhada

O modelo de responsabilidade compartilhada descreve as responsabilidades de segurança e conformidade entre o provedor de serviços em nuvem (Azure) e o cliente. No Azure, o provedor é responsável pela segurança da infraestrutura que compõe os serviços em nuvem, incluindo hardware, software, redes e instalações. Por outro lado, os clientes são responsáveis pela segurança de suas aplicações e dados, incluindo o gerenciamento de identidades, criptografia e configurações de rede. Este modelo ajuda as empresas a entenderem claramente onde suas responsabilidades começam e terminam.

## Como Criar um Banco de Dados SQL

Criar um banco de dados SQL no Azure é um processo direto que envolve algumas etapas:

1. **Acessar o Portal do Azure**: Entre na sua conta do Azure e acesse o portal.
2. **Selecionar "Criar um recurso"**: Clique na opção para criar um novo recurso.
3. **Escolher "Banco de Dados SQL"**: Na seção de bancos de dados, selecione a opção para Banco de Dados SQL.
4. **Configurar os detalhes do banco de dados**:
   - **Nome**: Defina um nome exclusivo para o banco de dados.
   - **Servidor**: Crie um novo servidor ou escolha um existente. Isso inclui definir a localização e a configuração de autenticação.
   - **Recursos**: Escolha o nível de desempenho e as opções de escalabilidade, como DTUs ou vCores.
5. **Configurações adicionais**: Configure opções como backup, segurança e firewall.
6. **Revisar e criar**: Revise as configurações e clique em "Criar" para finalizar a implantação.

Após a criação, você pode gerenciar o banco de dados através do portal do Azure ou usar ferramentas como o SQL Server Management Studio.

## Regiões do Azure e Zonas de Disponibilidade

O Azure está distribuído em diversas regiões ao redor do mundo, cada uma consistindo em um ou mais datacenters. As **Zonas de Disponibilidade** são um conjunto de datacenters em uma região que operam de forma independente para garantir alta disponibilidade e resiliência. Isso permite que os serviços permaneçam operacionais mesmo em caso de falhas em uma parte da infraestrutura.

## Pares de Regiões

Os **pares de regiões** no Azure são uma configuração que conecta duas regiões geográficas próximas. Essa configuração é utilizada para garantir a recuperação de desastres e alta disponibilidade, permitindo que os dados sejam replicados entre regiões. Por exemplo, se uma região falhar, a outra pode assumir as operações, minimizando a interrupção dos serviços.

## Regiões Soberanas

As **regiões soberanas** são datacenters do Azure que atendem a requisitos específicos de conformidade e soberania de dados de determinados países. Essas regiões garantem que os dados permaneçam dentro das fronteiras nacionais e cumpram regulamentos locais. Exemplos incluem a Microsoft Cloud Alemanha e a Microsoft Cloud para o Governo dos EUA.

## Grupos de Recursos

Os **grupos de recursos** são containers lógicos que permitem agrupar e gerenciar recursos do Azure. Eles facilitam a organização de recursos, como máquinas virtuais, bancos de dados e redes, e permitem a aplicação de políticas, controle de acesso e gerenciamento de custos de forma centralizada.

## Assinaturas do Azure

Uma **assinatura do Azure** é uma forma de acessar os serviços do Azure e gerenciar recursos. Cada assinatura possui limites de uso e pode incluir cobranças associadas. As organizações podem ter várias assinaturas para separar ambientes, como desenvolvimento, teste e produção, ou para diferentes departamentos ou projetos.

## Grupos de Gerenciamento

Os **grupos de gerenciamento** são uma camada hierárquica que permite organizar e gerenciar várias assinaturas do Azure de forma eficiente. Eles ajudam a aplicar políticas e controles de segurança em um conjunto de assinaturas, facilitando a governança e a conformidade em grandes organizações. Isso permite uma visão consolidada e um controle mais eficiente sobre os recursos do Azure.

## Serviços de Computação do Azure

O Azure oferece uma variedade de serviços de computação que permitem executar aplicações e gerenciar recursos de forma eficiente:

- **Máquinas Virtuais**: Proporcionam a capacidade de executar sistemas operacionais e aplicativos na nuvem, permitindo que os usuários escolham o tamanho e as especificações da VM de acordo com suas necessidades.
- **Conjuntos de Disponibilidade de Máquinas Virtuais**: Garantem que as VMs sejam implantadas em diferentes datacenters dentro da mesma região, aumentando a resiliência e a disponibilidade de aplicativos.
- **Área de Trabalho Virtual do Azure**: Permite que os usuários acessem desktops e aplicativos de qualquer lugar, oferecendo uma experiência semelhante a um desktop físico na nuvem.
- **Containers**: Facilita a criação, implantação e gerenciamento de aplicações em containers, permitindo uma abordagem mais ágil para o desenvolvimento e a operação.
- **Serviços de Kubernetes do Azure (AKS)**: Oferece um serviço gerenciado para orquestrar containers usando Kubernetes, simplificando o gerenciamento de clusters e a implantação de aplicações.
- **Azure Functions**: Um serviço de computação sem servidor que permite executar código em resposta a eventos, eliminando a necessidade de gerenciar servidores e infraestrutura.
- **Serviços de Aplicativo do Azure**: Proporciona uma plataforma para criar e hospedar aplicativos web e APIs, oferecendo recursos integrados como escalabilidade e gerenciamento.

## Serviços de Rede do Azure

O Azure disponibiliza diversos serviços de rede que ajudam a conectar e gerenciar recursos de forma segura e eficiente:

- **VNet (Virtual Network)**: Cria redes privadas isoladas na nuvem, permitindo que recursos se comuniquem de forma segura e eficiente.
- **Gateway de VPN**: Facilita a conexão segura entre a rede local e a VNet no Azure através de uma conexão VPN, garantindo que os dados sejam transmitidos de forma segura.
- **ExpressRoute**: Proporciona uma conexão privada e dedicada entre a infraestrutura local e o Azure, melhorando a segurança e a latência em comparação com conexões pela internet pública.
- **DNS do Azure**: Um serviço de gerenciamento de nomes de domínio que fornece resolução de nomes para serviços e recursos dentro do Azure, além de suporte para domínios públicos.
